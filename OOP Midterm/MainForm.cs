// Encryptor Project
// CKulig
// 4/2020
// This program is designed to take an input of four digits and encrypt or decrypt them as needed.
// The encryption methodology is as follows:
//      Replace each digit by the sum of that digit plus seven modulus ten.
//      Swap the first digit with the third digit and the second digit with the fourth

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace OOP_Midterm
{
    public partial class Form1 : Form
    {
        private static string nonsecureInput = null;
        private static string encInput = null;

        public Form1()
        {
            InitializeComponent();
        }

     
        private void encrypt_Click(object sender, EventArgs e)
        {
            nonsecureInput = stdInput.Text;

            if (!checkLength(nonsecureInput))
            {
                MessageBox.Show("Input needs to be four integral numbers.");            
            }
            else if (!vNumData(nonsecureInput))
            {
                MessageBox.Show("Cannot use letters or special characters.");
            }

            else
            {
                encryptedOutput.Text = encryptSrting(nonsecureInput, true);
            }

        }

        // To encrypt pass True as the second param, otherwise False for decrypt
        private string encryptSrting(string s, bool change) {

            int[] x = new int[4];
            string returnString = "";

            // if true encrypt
            if (change)
            {
                for (int i = 0; i < 4; i++)
                {
                    int y = (int)Char.GetNumericValue(s, i);
                    x[i] = ((y + 7) % 10);
                }
            }
            else {
                for (int i = 0; i < 4; i++)
                {
                    
                    int y = (int)Char.GetNumericValue(s, i);
                    if (y  == 8 || y == 9)
                    {
                        y = y - 7;
                    }
                    else { y = (y + 3)%10; }
                    x[i] = y;
                }
            }

            //Switching 1st & 3rd
            int temp = x[2];
            x[2] = x[0];
            x[0] = temp;

            //Switching 2nd & 4th
            temp = x[3];
            x[3] = x[1];
            x[1] = temp;

            for (int i = 0; i < 4; i++)
            {
                returnString += x[i];
            }

            x = null;
            return returnString;
        }
        
        // Returns FALSE if the string is above 4 characters
        private bool checkLength(string data)
        {
            return data.Length == 4;
        }

        // If there is a letter this will return FALSE (verify numerical data)
        private bool vNumData(string data)
        {
            bool result = true;
            foreach (char x in data)
            {
                if (x < '0' || x > '9')
                {                    
                    result = false;
                    break;                    
                }
            }
            return result;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            encInput = encryptedInput.Text;
            if (!checkLength(encInput))
            {
                MessageBox.Show("Input needs to be four integral numbers.");
            }
            else if (!vNumData(encInput))
            {
                MessageBox.Show("Cannot use letters or special characters.");
            }
            else
            {
                stdOutput.Text = encryptSrting(encInput, false);
            }
        }
    }
}
