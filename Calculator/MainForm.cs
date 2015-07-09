using System;
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
        private void SortingMassiv(object sender, EventArgs e)
        {
            try
            {
                string[] split = FirstArgument.Text.Split(new Char[] {' '});
                double[] array = new double[split.Length];
                for (int i = 0; i < split.Length; i++)
                {
                    array[i] = Validation.StringToDouble(split[i]);
                }
                string operation = (((Button) sender).Name);
                var op = SortingOfMassivFactory.CreateSorting(operation);
                double[] resultDoubleArray = op.Sort(array);
                string[] resultStringArray = new string[split.Length];
                string resultString = "";
                for (int i = 0; i < resultStringArray.Length; i++)
                {
                    resultString += resultStringArray[i] + ' ';
                }
                Result.Text = resultString;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
        
        private void CalculateTwoArgument(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Validation.StringToDouble(FirstArgument.Text);
                double secondArgument = Validation.StringToDouble(SecondArgument.Text);
                string operation = (((Button) sender).Name);
                var op = TwoArgumentFactory.CreateCalculator(operation);
                double result = op.Calculate(firstArgument, secondArgument);
                Result.Text = Convert.ToString(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
        
        private void CalculateOneArgument(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Validation.StringToDouble(FirstArgument.Text);
                string operation = (((Button) sender).Name);
                var op = OneArgumentFactory.CreateCalculator(operation);
                double result = op.Calculate(firstArgument);
                Result.Text = Convert.ToString(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }            
}
