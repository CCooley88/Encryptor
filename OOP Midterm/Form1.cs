// CIT-287 OOPL Midterm
// CKulig
// 4/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
           // Debug.WriteLine(insecureInput + " Is there a letter: " + vNumData(insecureInput));

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
                // To encrypt pass True as the second param, otherwise False for decrypt
                encryptedOutput.Text = encryptSrting(nonsecureInput, true);
            }

        }

        private string encryptSrting(string s, bool change) {

            int[] x = new int[4];
            string returnString = "";

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
                    //Debug.WriteLine("Y" + i + ": " + y);
                    if (y  == 8 || y == 9)
                    {
                        y = y - 7;
                    }
                    else { y = (y + 3)%10; }
                    x[i] = y;
                    //Debug.WriteLine("X" + i + ": " + x[i]);
                }
            }


            //Switching 1 & 3
            int temp = x[2];
            x[2] = x[0];
            x[0] = temp;

            //Switching 2 & 4
            temp = x[3];
            x[3] = x[1];
            x[1] = temp;

            for (int i = 0; i < 4; i++)
            {
                returnString += x[i];
                //Debug.WriteLine("Return string: " + returnString);
            }

            x = null;
            return returnString;
        }
        

        // Returns FALSE if the string is above 4 characters
        private bool checkLength(string data)
        {
            return data.Length == 4;
        }

        // If there is a letter this will return FALSE
        private bool vNumData(string data)
        {
            bool result = true;
            foreach (char x in data)
            {
                // Debug.WriteLine("Char: " + x + " is it less than 0 or greater than 9" + (x<0 || x>9));
                if (x < '0' || x > '9')
                {
                    if (x != '.')
                    {
                        //Debug.WriteLine("Char = " + x + " is below 0 and above 9 and is not a . ");
                        result = false;
                        break;
                    }
                }
            }
            //Regex regex = new Regex(("^[0-9]+$"));
            //return regex.IsMatch(data);
            return result;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            encInput = encryptedInput.Text;
            // Debug.WriteLine(insecureInput + " Is there a letter: " + vNumData(insecureInput));

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
                // To encrypt pass True as the second param, otherwise False for decrypt
                stdOutput.Text = encryptSrting(encInput, false);
            }
            




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
