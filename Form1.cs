namespace CalculatorDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate the operations in the combo box

            CboOperation.Items.Add("Add");
            CboOperation.Items.Add("Subtract");
            CboOperation.Items.Add("Multiply");
            CboOperation.Items.Add("Divide");

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // create an intance of the calculator class
            Calculator calculator = new Calculator();

            // capture the number input into a variable
            double firstNumber = double.Parse(TxtFirstNumber.Text);
            double secondNumber = double.Parse(TxtSecondNumber.Text);
            double result = 0.0;

            // do the operation
            // what is being switched
            switch (CboOperation.Text)
            {
                case "Add":
                    result = calculator.Add(firstNumber, secondNumber);
                    break;

                case "Subtract":
                    result = calculator.Subtract(firstNumber, secondNumber);
                    break;

                case "Multiply":
                    result = calculator.Multiply(firstNumber, secondNumber);
                    break;

                case "Divide":
                    result = calculator.Divide(firstNumber, secondNumber);
                    break;

                default:
                    break;
            }
            // store the result into the result txtbox
            TxtResult.Text = result.ToString();



        }
    }
}