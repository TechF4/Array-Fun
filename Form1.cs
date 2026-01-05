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

            array1[0] = randGen.Next(1, 11);
            array1[1] = randGen.Next(1, 11);
            array1[2] = randGen.Next(1, 11);
            array1[3] = randGen.Next(1, 11);
            array1[4] = randGen.Next(1, 11);
            array1[5] = randGen.Next(1, 11);
            array1[6] = randGen.Next(1, 11);
            array1[7] = randGen.Next(1, 11);
            array1[8] = randGen.Next(1, 11);

            int[] array2 = new int[9];
            array2[0] = randGen.Next(1, 11);
            array2[1] = randGen.Next(1, 11);
            array2[2] = randGen.Next(1, 11);
            array2[3] = randGen.Next(1, 11);
            array2[4] = randGen.Next(1, 11);
            array2[5] = randGen.Next(1, 11);
            array2[6] = randGen.Next(1, 11);
            array2[7] = randGen.Next(1, 11);
            array2[8] = randGen.Next(1, 11);


        }
    }
}
