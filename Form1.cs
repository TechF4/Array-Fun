/*
Student Name: Sena Unal
Completion Date: 2026/01/04
Assignment Name: Array Fun
 */

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
            // Initialized array1
            int[] array1 = new int[9];

            // Assigned random values 0-9 to array 1, from index 0-8
            array1[0] = randGen.Next(0, 10);
            array1[1] = randGen.Next(0, 10);
            array1[2] = randGen.Next(0, 10);
            array1[3] = randGen.Next(0, 10);
            array1[4] = randGen.Next(0, 10);
            array1[5] = randGen.Next(0, 10);
            array1[6] = randGen.Next(0, 10);
            array1[7] = randGen.Next(0, 10);
            array1[8] = randGen.Next(0, 10);


            // Initialized array2
            int[] array2 = new int[9];

            // Assigned random values 0-9 to array 1, from index 0-8
            array2[0] = randGen.Next(0, 10);
            array2[1] = randGen.Next(0, 10);
            array2[2] = randGen.Next(0, 10);
            array2[3] = randGen.Next(0, 10);
            array2[4] = randGen.Next(0, 10);
            array2[5] = randGen.Next(0, 10);
            array2[6] = randGen.Next(0, 10);
            array2[7] = randGen.Next(0, 10);
            array2[8] = randGen.Next(0, 10);


            // Displayed the values of array1 indexes from 0-8 in order
            for (int i = 0; i <= 8; i++)
            { array1Label.Text += array1[i] + " "; }


            // Displayed the values of array2 indexes from 0-8 in order
            for (int i = 0; i <= 8; i++)
            { array2Label.Text += array2[i] + " "; }


            // Displayed the values of array1 indexes from 0-8 in reverse order
            for (int i = 8; i >= 0; i--)
            { array3Label.Text += array1[i] + " "; }


            // Displayed the Max value of array 1
            maxLabel.Text = Convert.ToString(array1.Max());


            // Displayed the average of array 1
            averageLabel.Text = Convert.ToString(array1.Average());


            // Initialized the evenSum variable so that its lifetime is not only limited to the loop
            int evenSum = 0;

            // Made a loop that checks if an index value of the array is even (if even I added, else I skipped the iteration)
            for (int i = 0; i <= 8; i++)
            { 
                if (array1[i] % 2 == 0)
                {
                    evenSum += array1[i];
                }

                else { continue; }
            }

            // Displayed the sum of all the even numbers
            sumEvenLabel.Text = evenSum.ToString();


            // Initialized the numOf3 variable so that its lifetime is not only limited to the loop
            int numOf3 = 0;

            // Made a loop that checks if an index value of the array is three (if three I added to the count, else I skipped the iteration)
            for (int i = 0; i <= 8; i++)
            {
                if (array1[i] == 3)
                {
                    numOf3 += 1;
                }

                else { continue; }
            }

            // Displayed the number of 3s in the array
            threesLabel.Text = numOf3.ToString();


            // Initialized the matchCount variable so that its lifetime is not only limited to the loop
            int matchCount = 0;

            // Made a loop that checks if the index value of array1 is matching array2
            for (int i = 0; i <= 8; i++)
            {
                if (array1[i] == array2[i])
                {
                    matchCount += 1;
                }

                else { continue; }
            }

            // Displayed the number of matching numbers in the arrays
            matchingLabel.Text = matchCount.ToString();


            // Made a loop that checks if an index value of the array is zero, and checks it in order
            // When it finds a 0 then it displays which index it is stored at, if there are none then "null" is displayed
            for (int i = 0; i <= 8; i++)
            {
                if (array1[i] == 0)
                {
                    zeroLabel.Text = i.ToString();
                    break;
                }

                else
                {
                    zeroLabel.Text = "null";
                }
            }

            
            // Made a variable to temporarily hold the value of array1
            int[] tempArrayHolder = array1;

            // Assigned the value of array2 to array1
            array1 = array2;

            // Assigned the value of array1 to array2 using the temporary holder
            array2 = tempArrayHolder;

            // Displayed the switched value of array2
            for (int i = 0; i <= 8; i++)
            { ar2ar1Label.Text += array2[i] + " "; }

            // Displayed the switched value of array1
            for (int i = 0; i <= 8; i++)
            { ar1ar2Label.Text += array1[i] + " "; }

        }

        private void a2a1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
