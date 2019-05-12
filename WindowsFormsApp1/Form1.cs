using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDecipher_Click(object sender, EventArgs e)
        {
            var deciphered = TranspositionCipher.Decipher(TextBoxToDecipher.Text);
            TextBoxToEnchipher.Text = deciphered;
        }

        private void ButtonEncipher_Click(object sender, EventArgs e)
        {
            var enciphered = TranspositionCipher.Encipher(TextBoxToEnchipher.Text);
            TextBoxToDecipher.Text = enciphered;
        }
    }
}
