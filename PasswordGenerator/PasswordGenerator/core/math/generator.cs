using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PasswordGenerator.core.math
{
    internal class generator
    {
        private static Random random = new Random();

        public static string pass(string chars,int length)
        {
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void Generate(ComboBox comboBoxLength, ComboBox comboBoxType, TextBox textBox)
        {
            int length = 0;
            int type = 0;

            string upper = "ABCDEFGHIKLMNOPQRSTVXYZ";
            string lowwer = "abcdefghiklmnopqrstvxyz";
            string digits = "ABCDEFGHIKLMNOPQRSTVXYZabcdefghiklmnopqrstvxyz1234567890!@#$%^&*()";
            
            for(int i = 0; i <= comboBoxLength.Items.Count; ++i)
            {
                if(comboBoxLength.SelectedIndex == i)
                {
                    length = i + 1;
                }
            }
            for (int i = 0; i <= comboBoxType.Items.Count; ++i)
            {
                if (comboBoxType.SelectedIndex == i)
                {
                    type = i + 1;
                }
            }
            textBox.Text = (type == 1) ? pass(lowwer, length) : (type == 2) ? pass(upper, length) : (type == 3) ? pass(digits, length) : textBox.Text;

            using(StreamWriter streamWriter = new StreamWriter("_passwords.txt", true))
            {
                streamWriter.WriteLine($"Day: {DateTime.Now.ToString("dd MMMM yyyy")} \nTime: {DateTime.Now.ToString("HH:mm:ss")}\nPassword: {textBox.Text}\n");
            }
        }
    }
}
