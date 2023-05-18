import qrcode
import qrcode
import numpy as np
import socket
import io
import subprocess

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Connect the socket to the server's IP address and port
server_address = ('localhost', 12345)
sock.connect(server_address)


# The text to be encoded as QR code



buffer = sock.recv(1024)
result = buffer.decode()
text = "2|99|0945052542|Phan Le Thanh Cong||0|0|" + result
filename = result + ".png"
QRCodefile = filename
# instantiate QRCode object
qrObject = qrcode.QRCode()
# add data to the QR code
qrObject.add_data(text)
# compile the data into a QR code array
qrObject.make()

imgByteArr = io.BytesIO()
qrImage = qrObject.make_image()
qrImage.save(imgByteArr, format='PNG')
imgBytes = imgByteArr.getvalue()

sock.sendall(imgBytes)
sock.close()