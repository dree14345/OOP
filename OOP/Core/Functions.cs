using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Core
{
    public static class Functions
    {
        private static void ValidateField(ErrorProvider errorProvider, Control control, string errorMessage)
        {
            if (control is TextBox textBox)
            {
                errorProvider.SetError(textBox, string.IsNullOrWhiteSpace(textBox.Text) ? errorMessage : "");
            }
            else if (control is NumericUpDown numericUpDown)
            {
                errorProvider.SetError(numericUpDown, numericUpDown.Value <= 0 ? errorMessage : "");
            }
            else if (control is ComboBox comboBox)
            {
                errorProvider.SetError(comboBox, (comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox.Text)) ? errorMessage : "");
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                errorProvider.SetError(dateTimePicker, dateTimePicker.Value == DateTimePicker.MinimumDateTime ? errorMessage : "");
            }
        }

        public static bool ValidateFields(ErrorProvider errorProvider, params (Control control, string errorMessage)[] fields)
        {
            bool isValid = true;

            foreach (var (control, errorMessage) in fields)
            {
                ValidateField(errorProvider, control, errorMessage);
                if (!string.IsNullOrEmpty(errorProvider.GetError(control)))
                {
                    isValid = false;
                }
            }

            return isValid;
        }


    }
}
