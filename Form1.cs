using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Fun
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[9];

            array1[0] = randGen.Next(1, 10);
            array1[1] = randGen.Next(1, 10);
            array1[2] = randGen.Next(1, 10);
            array1[3] = randGen.Next(1, 10);
            array1[4] = randGen.Next(1, 10);
            array1[5] = randGen.Next(1, 10);
            array1[6] = randGen.Next(1, 10);
            array1[7] = randGen.Next(1, 10);
            array1[8] = randGen.Next(1, 10);

            int[] array2 = new int[9];
            array2[0] = randGen.Next(1, 10);
            array2[1] = randGen.Next(1, 10);
            array2[2] = randGen.Next(1, 10);
            array2[3] = randGen.Next(1, 10);
            array2[4] = randGen.Next(1, 10);
            array2[5] = randGen.Next(1, 10);
            array2[6] = randGen.Next(1, 10);
            array2[7] = randGen.Next(1, 10);
            array2[8] = randGen.Next(1, 10);

            for (int i = 0; i <= 8; i++)
            { array1Label.Text += array1[i] + " "; }

            for (int i = 0; i <= 8; i++)
            { array2Label.Text += array2[i] + " "; }

            for (int i = 8; i >= 0; i--)
            { array3Label.Text += array1[i] + " "; }


            maxLabel.Text = Convert.ToString(array1.Max());


            averageLabel.Text = Convert.ToString(array1.Average());


            int evenSum = 0;

            for (int i = 0; i <= 8; i++)
            { 
                if (array1[i] % 2 == 0)
                {
                    evenSum += array1[i];
                }

                else { continue; }
            }

            sumEvenLabel.Text = evenSum.ToString();


            int numOf3 = 0;

            for (int i = 0; i <= 8; i++)
            {
                if (array1[i] == 3)
                {
                    numOf3 += 1;
                }

                else { continue; }
            }

            threesLabel.Text = numOf3.ToString();

        }
    }
}
