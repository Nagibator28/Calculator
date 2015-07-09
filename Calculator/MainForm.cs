﻿using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgument;
using Calculator.SortingOfMassiv;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private double StringToDouble(string text)
        {
            double result;
            if (double.TryParse(text, out result))
            {
                return result;
            }
            else
            {
                throw new Exception("Eror");
            }
         }

        private void SortingMassiv(object sender, EventArgs e)
        {
           string [] split = FirstArgument.Text.Split(new Char[]{' '});
           double[] array = new double[split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                array[i] = StringToDouble(split[i]);
            }

            string operation = (((Button) sender).Name);
            var op = SortingOfMassivFactory.CreateSorting(operation);
            double[] resultDoubleArray = op.Sort(array);

            string[] resultStringArray = new string[split.Length];

            for (int i = 0; i < array.Length; i++)
            {
                resultStringArray[i] = Convert.ToString(resultDoubleArray[i]);
            }

            string resultString = "";

            for (int i = 0; i < resultStringArray.Length; i++)
            {
                resultString += resultStringArray[i] +' ';
            }

            Result.Text = resultString;


        }
        
        private void CalculateTwoArgument(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);
            double secondArgument = StringToDouble(SecondArgument.Text);
            string operation = (((Button) sender).Name);
            var op = TwoArgumentFactory.CreateCalculator(operation);
            double result = op.Calculate(firstArgument, secondArgument);
            Result.Text = Convert.ToString(result);

        }
        
        private void CalculateOneArgument(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);
            string operation = (((Button) sender).Name);
            var op = OneArgumentFactory.CreateCalculator(operation);
            double result = op.Calculate(firstArgument);
            Result.Text = Convert.ToString(result);
        }
    }            
}
