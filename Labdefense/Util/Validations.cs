using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labdefense.Util
{
    public class Validations
    {
        private ErrorProvider errorProvider = new ErrorProvider();
       
        public void ClearText(TextBox[] textBoxes)
        {
            foreach (TextBox box in textBoxes)
            {
                box.Text = string.Empty;
            }
        }
        public bool TextNullEmpty(TextBox[] textBoxes)
        {
            bool TextNull = false;

            foreach (TextBox txt in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    errorProvider.SetError(txt, "Este campo es obligatorio.");
                    TextNull = true;
                }
                else
                {
                    errorProvider.SetError(txt, "");
                }
            }

            if (TextNull)
            {

                System.Media.SystemSounds.Exclamation.Play();
            }

            return TextNull;
        }

        public bool IsValidId(TextBox[] identification)
        {
            bool idWrong = false;
            string pattern = @"^\d{3}-\d{6}-\d{4}[A-Z]$";

            Regex regex = new Regex(pattern);
            foreach (TextBox txt in identification)
            {
                if (!regex.IsMatch(txt.Text))
                {
                    errorProvider.SetError(txt, "Esta identificacion no es valida");
                    idWrong = true;
                }
                else
                {
                    errorProvider.SetError(txt, "");
                }

            }
            if (idWrong)
            {

                System.Media.SystemSounds.Exclamation.Play();
            }

            return idWrong;
        }

        public bool IsValidCarnet(TextBox[] carnet)

        {
            bool carnetWrong = false;

            string patterncarnet = @"^20\d{2}-\d{4}[A-Z]$";
            Regex regexcarnet = new Regex(patterncarnet);

            foreach (TextBox txtcarnet in carnet)
            {
                if (!regexcarnet.IsMatch(txtcarnet.Text))
                {
                    errorProvider.SetError(txtcarnet, "Este carnet no es valido");
                    carnetWrong = true;
                }
                else
                {
                    errorProvider.SetError(txtcarnet, "");
                }
            }
            if (carnetWrong)
            {

                System.Media.SystemSounds.Exclamation.Play();
            }

            return carnetWrong;
        }
        public void ValidateNumberInput(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (ch == 8)
            {
                e.Handled = false;
                return;
            }

            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;



            if (!char.IsDigit(ch) && ch != '.')
            {
                e.Handled = true;
                return;
            }

            if (ch == '.')
            {
                bool hasDecimal = currentText.Contains(".");

                e.Handled = hasDecimal;

                if (!hasDecimal && currentText.Length == 0)
                {

                    textBox.Text = "0" + textBox.Text;
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else if (currentText.EndsWith("."))
                {

                    textBox.Text += "0";
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }


        }

        public bool NumberValif(TextBox[] Num)
        {
            bool numwrong = false;
            string pattern = @"^d\{8}$";

            Regex regex = new Regex(pattern);
            foreach (TextBox txt in Num)
            {
                if (!regex.IsMatch(txt.Text))
                {
                    errorProvider.SetError(txt, "Esta identificacion no es valida");
                    numwrong = true;
                }
                else
                {
                    errorProvider.SetError(txt, "");
                }

            }
            if (numwrong)
            {

                System.Media.SystemSounds.Exclamation.Play();
            }

            return numwrong;
        }
    }

}




