using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var deciphered = Decipher(TextBoxToDecipher.Text, TextBoxToDecipherKey.Text);
            TextBoxToEnchipher.Text = deciphered;
        }

        private void ButtonEncipher_Click(object sender, EventArgs e)
        {
            var enciphered = Encipher(TextBoxToEnchipher.Text, TextBoxToEncipherKey.Text, '-');
            TextBoxToDecipher.Text = enciphered;
        }

        private void TextBoxToDecipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxToEnchipher_TextChanged(object sender, EventArgs e)
        {

        }
    
        /// <returns>Indexes of alphabetically sorted key string</returns> 
        private static int[] GetShiftIndexes(string key)
        {
            int keyLength = key.Length;
            int[] indexes = new int[keyLength];
            KeyValuePair<int, char>[] sortedKey = new KeyValuePair<int, char>[keyLength];
            int i;

            for (i = 0; i < keyLength; i++)
            {
                sortedKey[i] = new KeyValuePair<int, char>(i, key[i]);
            }

            Array.Sort(sortedKey, (first, second) => first.Value.CompareTo(second.Value));

            for (i = 0; i < keyLength; i++)
            {
                indexes[sortedKey[i].Key] = i;
            }

            return indexes;
        }

        public static string Encipher(string input, string key, char padChar)
        {
            input = (input.Length % key.Length == 0) ? input : input.PadRight(input.Length - (input.Length % key.Length) + key.Length, padChar);

            StringBuilder outputBuilder = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = key.Length;
            int totalRows = (int) Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] sortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; i++)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; i++)
            {
                for (j = 0; j < totalColumns; j++)
                {
                    colChars[j, i] = rowChars[i, j];
                }
                    
            }

            for (i = 0; i < totalColumns; i++)
            {
                for (j = 0; j < totalRows; j++)
                {
                    sortedColChars[shiftIndexes[i], j] = colChars[i, j];
                }
            }

            for (i = 0; i < totalChars; i++)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                outputBuilder.Append(sortedColChars[currentRow, currentColumn]);
            }

            return outputBuilder.ToString();
        }

        public static string Decipher(string input, string key)
        {
            StringBuilder outputBuilder = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = (int)Math.Ceiling((double)totalChars / key.Length);
            int totalRows = key.Length;
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] unsortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; i++)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; i++)
            {
                for (j = 0; j < totalColumns; j++)
                {
                    colChars[j, i] = rowChars[i, j];
                }
            }
        
            for (i = 0; i < totalColumns; i++)
            {
                for (j = 0; j < totalRows; j++)
                {
                    unsortedColChars[i, j] = colChars[i, shiftIndexes[j]];
                }    
            }
                
            for (i = 0; i < totalChars; i++)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                outputBuilder.Append(unsortedColChars[currentRow, currentColumn]);
            }

            return outputBuilder.ToString();
        }
    }
}
