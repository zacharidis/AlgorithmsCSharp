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
    }
}