using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordGenerator.core.math;

namespace PasswordGenerator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generator.GENERATE(comboBox1,comboBox2,textBox1);
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Copied!");
            }
            else { MessageBox.Show("Password not generated"); }
        }
    }
}
