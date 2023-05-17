import face_recognition
import os, sys
import cv2
import numpy as np
import math
import time
import struct
import socket
import io
# Helper
def face_confidence(face_distance, face_match_threshold=0.6):
    range = (1.0 - face_match_threshold)
    linear_val = (1.0 - face_distance) / (range * 2.0)

    if face_distance > face_match_threshold:
        return str(round(linear_val * 100, 2)) + '%'
    else:
        value = (linear_val + ((1.0 - linear_val) * math.pow((linear_val - 0.5) * 2, 0.2))) * 100
        return str(round(value, 2)) + '%'


class FaceRecognition:
    face_locations = []
    face_encodings = []
    face_names = []
    known_face_encodings = []
    known_face_names = []
    process_current_frame = True

    def __init__(self):
        self.encode_faces()

    def encode_faces(self):
        facedirectory = r'E:\STUDY\2022-2023\Ltrinh Windows\WinFormsRestaurant\WinFormsRestaurant\bin\Debug\Faces'
        person_names = os.listdir(facedirectory)
        for person_name in person_names:
            person_directory = os.path.join(facedirectory, person_name)
            for image in os.listdir(person_directory):
                face_image = face_recognition.load_image_file(os.path.join(person_directory, image))
                face_encoding = face_recognition.face_encodings(face_image)[0]

                self.known_face_encodings.append(face_encoding)
                self.known_face_names.append(person_name)
                #print(f"Encoded image {image} for {person_name}.")
        #print(f"Encoded {len(os.listdir(facedirectory))} images for {len(person_names)} persons.")

    def run_recognition(self):
        # Create a TCP/IP socket
        server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server_socket.connect(('localhost', 8000))

        video_capture = cv2.VideoCapture(0)
        if not video_capture.isOpened():
            sys.exit('Video source not found...')
        confidence = ''

        while True:
            ret, frame = video_capture.read()

            # Only process every other frame of video to save time
            if self.process_current_frame:
                # Resize frame of video to 1/4 size for faster face recognition processing
                small_frame = cv2.resize(frame, (0, 0), fx=0.25, fy=0.25)

                # Convert the image from BGR color (which OpenCV uses) to RGB color (which face_recognition uses)
                rgb_small_frame = small_frame[:, :, ::-1]

                # Find all the faces and face encodings in the current frame of video
                face_locations = face_recognition.face_locations(rgb_small_frame)
                face_encodings = face_recognition.face_encodings(small_frame, face_locations)

                face_names = []
                found_face = False
                for face_encoding in face_encodings:
                    # See if the face is a match for the known face(s)
                    matches = face_recognition.compare_faces(self.known_face_encodings, face_encoding)
                    name = "Unknown"
                    confidence = '???'

                    # Calculate the shortest distance to face
                    face_distances = face_recognition.face_distance(self.known_face_encodings, face_encoding)

                    best_match_index = np.argmin(face_distances)

                    if matches[best_match_index]:
                        name = self.known_face_names[best_match_index]
                        confidence = face_confidence(face_distances[best_match_index])
                        if float(confidence[:-1]) > 80:
                            print(name)
                            found_face = True  # Set the flag variable to True
                            break
                    # face_names.append(f'{name} ({confidence})')

                if found_face:
                    video_capture.release()
                    cv2.destroyAllWindows()
                    break

            self.process_current_frame = not self.process_current_frame

            # Display the results
            for (top, right, bottom, left), name in zip(face_locations, face_names):
                # Scale back up face locations since the frame we detected in was scaled to 1/4 size
                top *= 4
                right *= 4
                bottom *= 4
                left *= 4

                # Create the frame with the name
                # cv2.rectangle(frame, (left, top), (right, bottom), (0, 0, 255), 2)
                # cv2.rectangle(frame, (left, bottom - 35), (right, bottom), (0, 0, 255), cv2.FILLED)
                # cv2.putText(frame, name, (left + 6, bottom - 6), cv2.FONT_HERSHEY_DUPLEX, 0.8, (255, 255, 255), 1)

            # Display the resulting image
            #cv2.imshow('Face Recognition', frame)

            _, buffer = cv2.imencode('.jpg', frame)

            # Send the image size to the server
            server_socket.sendall(struct.pack('<L', len(buffer)))

            # Send the image data to the server
            server_socket.sendall(buffer.tobytes())

            # Hit 'q' on the keyboard to quit!
            if cv2.waitKey(1) == ord('q'):
                break

        # Release handle to the webcam
        video_capture.release()
        cv2.destroyAllWindows()
        server_socket.close()

if __name__ == '__main__':
    fr = FaceRecognition()
    fr.run_recognition()


