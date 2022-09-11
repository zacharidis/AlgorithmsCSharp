using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;
using System;


namespace AlgorithmsCSharp
{   /// <summary>
///  Implementing various algorithms in C# 
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Algorithms in C# by Georgios Zacharidis . Thank you for trying out this app");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = Interaction.InputBox("Enter a number ");
            int intInput =0 ; 
            
            if (input != null)
            {
              if( int.TryParse(input, out intInput))
                {
                    listBox1.Items.Add(Class1.Factorial(intInput));

                };
                
            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter a number ");
            int intInput = 0;
            if (input != null)
            {
                if (int.TryParse(input, out intInput))
                {
                    listBox1.Items.Add(Class1.Fibonacci(intInput));

                };

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter a number ");
            int intInput = 0;
            if (input != null)
            {
                if (int.TryParse(input, out intInput))
                {
                    listBox1.Items.Add(Class1.SumOfDigits(intInput));

                };

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string baseNumber = Interaction.InputBox("Enter the base number");
            string expoNumber = Interaction.InputBox("Enther the exponential");
            int baseInt;
            int expoInt;

            if(int.TryParse(baseNumber,out baseInt)&& int.TryParse(expoNumber,out expoInt))
            {
                listBox1.Items.Add(Class1.RecursionPower(baseInt, expoInt));
            }




        }
    }
}