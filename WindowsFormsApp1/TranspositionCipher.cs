using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public static class TranspositionCipher
    {
        private const string DefaultKey = "ElPsyCongroo";
        
        /// <returns>Indexes of alphabetically sorted string serving as a key for the cipher</returns> 
        private static int[] GetShiftIndexes(string key = DefaultKey)
        {
            int[] indexes = new int[key.Length];
            KeyValuePair<int, char>[] sortedKey = new KeyValuePair<int, char>[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                sortedKey[i] = new KeyValuePair<int, char>(i, key[i]);
            }

            Array.Sort(sortedKey, (first, second) => first.Value.CompareTo(second.Value));

            for (int i = 0; i < key.Length; i++)
            {
                indexes[sortedKey[i].Key] = i;
            }

            return indexes;
        }

        public static string Encipher(string input, string key = DefaultKey, char padChar = '-')
        {
            // Add padding chars to the end of input string as input.Length must be a multiple of key.Length
            input = input.Length % key.Length == 0 ? input : input.PadRight(input.Length - input.Length % key.Length + key.Length, padChar);

            StringBuilder outputBuilder = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = key.Length;
            int totalRows = (int) Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] sortedColChars = new char[totalColumns, totalRows];
            int[] shiftIndexes = GetShiftIndexes(key);

            // Split input chars into a matrix
            for (int i = 0; i < totalChars; i++)
            {
                int currentRow = i / totalColumns;
                int currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            // Transpose the matrix
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalColumns; j++)
                {
                    colChars[j, i] = rowChars[i, j];
                }                
            }

            // Sort every row of the matrix
            for (int i = 0; i < totalColumns; i++)
            {
                for (int j = 0; j < totalRows; j++)
                {
                    sortedColChars[shiftIndexes[i], j] = colChars[i, j];
                }
            }

            // Add every matrix item to a string builder
            for (int i = 0; i < totalChars; i++)
            {
                int currentRow = i / totalRows;
                int currentColumn = i % totalRows;
                outputBuilder.Append(sortedColChars[currentRow, currentColumn]);
            }

            return outputBuilder.ToString();
        }

        public static string Decipher(string input, string key = DefaultKey)
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

            // Split input chars into a matrix
            for (i = 0; i < totalChars; i++)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            // Transpose the matrix
            for (i = 0; i < totalRows; i++)
            {
                for (j = 0; j < totalColumns; j++)
                {
                    colChars[j, i] = rowChars[i, j];
                }
            }
        
            // Reverse the sorting of every row of the matrix
            for (i = 0; i < totalColumns; i++)
            {
                for (j = 0; j < totalRows; j++)
                {
                    unsortedColChars[i, j] = colChars[i, shiftIndexes[j]];
                }    
            }
                
            // Add every matrix item to a string builder
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