using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLaboratorio2.Util
{
    public class Validations
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public bool TextNullOrEmpty(Control control)
        {
            errorProvider.SetError(control, "");

            if (control is ComboBox comboBox)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    errorProvider.SetError(comboBox, "Cannot be null or empty");
                    return false;
                }
            }

            if (control is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorProvider.SetError(textBox, "Cannot be null or empty");
                    return false;
                }
            }

            if (control is MaskedTextBox maskedTextBox)
            {
                if (!maskedTextBox.MaskFull)
                {
                    errorProvider.SetError(maskedTextBox, "Cannot be null or empty");
                    return false;
                }
            }

            return true;
        }
    }
}
