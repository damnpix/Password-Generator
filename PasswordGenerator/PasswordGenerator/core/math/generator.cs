using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator.core.math
{
    internal class generator
    {
        private static Random random = new Random();
        public static string pass(string chars,int length)
        {
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void GENERATE(ComboBox comboBoxLength, ComboBox comboBoxType, TextBox textBox)
        {
            int length = 0;
            int type = 0;

            string upper = "ABCDEFGHIKLMNOPQRSTVXYZ";
            string lowwer = "abcdefghiklmnopqrstvxyz";
            string digits = "ABCDEFGHIKLMNOPQRSTVXYZabcdefghiklmnopqrstvxyz1234567890!@#$%^&*()";

            switch (comboBoxLength.SelectedIndex) {

                case 0:
                    length = 1;
                    break;
                case 1:
                    length = 2;
                    break;
                case 2:
                    length = 3;
                    break;
                case 3:
                    length = 4;
                    break;
                case 4:
                    length = 5;
                    break;
                case 5:
                    length = 6;
                    break;
                case 6:
                    length = 7;
                    break;
                case 7:
                    length = 8;
                    break;
                case 8:
                    length = 9;
                    break;
                case 9:
                    length = 10;
                    break;
                case 10:
                    length = 11;
                    break;
                case 11:
                    length = 12;
                    break;
                default:
                    MessageBox.Show("Please select length!");
                    break;
            }
            switch (comboBoxType.SelectedIndex)
            {
                // 1 = low; 2 = medium; 3 = high
                case 0:
                    type = 1;
                    break;
                case 1:
                    type = 2;
                    break;
                case 2:
                    type = 3;
                    break;
                default:
                    MessageBox.Show("Please select type!");
                    break;
            }

            if(type == 1) textBox.Text = pass(lowwer, length);
            if (type == 2) textBox.Text = pass(upper, length);
            if (type == 3) textBox.Text = pass(digits, length);
        }
    }
}
