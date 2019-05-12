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
            string deciphered;
            if (TextBoxToDecipherKey.Text.Length > 0)
            {
                deciphered = TranspositionCipher.Decipher(TextBoxToDecipher.Text, TextBoxToDecipherKey.Text);
            }
            else
            {
                deciphered = TranspositionCipher.Decipher(TextBoxToDecipher.Text);
            }

            TextBoxToEnchipher.Text = deciphered;
        }

        private void ButtonEncipher_Click(object sender, EventArgs e)
        {
            string enciphered;
            if (TextBoxToEncipherKey.Text.Length > 0)
            {
                enciphered = TranspositionCipher.Encipher(TextBoxToEnchipher.Text, TextBoxToEncipherKey.Text);
            }
            else
            {
                enciphered = TranspositionCipher.Encipher(TextBoxToEnchipher.Text);
            }

            TextBoxToDecipher.Text = enciphered;
        }
    }
}