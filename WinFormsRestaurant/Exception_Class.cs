using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRestaurant
{
    internal class Exception_Class
    {
        public bool BlankBox(Form form)
        {
            var textBoxes = form.Controls.OfType<TextBox>();
            var comboBoxes = form.Controls.OfType<ComboBox>();
            var dateTimePickers = form.Controls.OfType<DateTimePicker>();
            var pictureBoxes = form.Controls.OfType<PictureBox>();
            var radioButtons = form.Controls.OfType<RadioButton>();

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }
            }

            foreach (var comboBox in comboBoxes)
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    return false;
                }
            }

            foreach (var dateTimePicker in dateTimePickers)
            {
                if (dateTimePicker.Value == null)
                {
                    return false;
                }
            }

            foreach (var pictureBox in pictureBoxes)
            {
                if (pictureBox.Image == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
