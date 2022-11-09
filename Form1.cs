using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rabin_Encryption
{
    public partial class Form1 : Form
    {
        byte[] input;
        byte[] result;
        List<int> theQR = new List<int>() { 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 26, 61, 98, 137, 178, 221, 3, 50, 99, 150, 203, 258, 52, 111, 172, 235, 37, 104, 173, 244, 54, 129, 206, 22, 103, 186, 8, 95, 184, 12, 105, 200, 34, 133, 234, 74, 179, 23, 132, 243, 93, 208, 62, 181, 39, 162, 24, 151, 17, 148, 18, 153, 27, 166, 44, 187, 69, 216, 102, 253, 143, 35, 192, 88, 249, 149, 51, 218, 124, 32, 205, 117, 31, 210, 128, 48, 233, 157, 83, 11, 204, 136, 70, 6, 207, 147, 89, 33, 242, 190, 140, 92, 46, 2, 223, 183, 145, 109, 75, 43, 13, 248, 222, 198, 176, 156, 138, 122, 108, 96, 86, 78, 72, 68, 66 };

        public Form1()
        {
            InitializeComponent();
        }
        
        // Opening a file
        private byte[] openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(fileName);
                return fileBytes;
            }
            else
            {
                return null;
            }
        }

        // gets an integer and returns and array of the QR of it
        private int[] getQR(int p)
        {
            List<int> Result = new List<int>();
            Result.Add(0);
            Result.Add(1);
            for (int i = 2; i < p; i++)
            {
                if (!Result.Contains(Convert.ToInt32(Math.Pow(i, 2)) % p))
                {
                    Result.Add(Convert.ToInt32(Math.Pow(i, 2)) % p);
                }
            }
            return Result.ToArray();
        }
        private void OpenfileBTN_Click(object sender, EventArgs e)
        {
            input = openFile();
            result = new byte[input.Length];
            if (input == null)
                return;
            StringBuilder sb = new StringBuilder();
            input.ToList().ForEach(i => sb.Append(i + ","));
            InputTXTBX.Text = sb.ToString();
        }

        private void EncBTN_Click(object sender, EventArgs e)
        {
            if(InputTXTBX.Text == "")
            {
                MessageBox.Show("There is nothing to encrypt");
                return;
            }
            for(int i = 0; i < input.Length; i++)
            {
                result[i] = Convert.ToByte(encrypt(input[i]));
            }
            StringBuilder sb = new StringBuilder();
            result.ToList().ForEach(i => sb.Append(i + ","));
            ResultTXTBX.Text = sb.ToString();
        }

        private int encrypt(int result)
        {
            //int result = plain;
            if (theQR.Contains(result))
            {
                result = Convert.ToInt32(Math.Pow(result, 2) % 263);
                if (result > 255)
                    return encrypt(result);
                return result;
            }
            else
            {
                result = 263 - Convert.ToInt32(Math.Pow(result, 2) % 263);
                if (result > 255)
                    return encrypt(result);
                return result;
            }
        }

        private void SavefileBTN_Click(object sender, EventArgs e)
        {
            if (ResultTXTBX.Text == "")
            {
                MessageBox.Show("There is nothing to save");
                return;
            }

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Image file(*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save The Selected text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, result);
            }
        }
    }
}
