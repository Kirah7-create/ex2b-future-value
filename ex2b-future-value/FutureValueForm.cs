namespace ex2b_future_value
{
    public partial class FormFutureValueForm : Form
    {
        public FormFutureValueForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //1. Obtain the user inputs from the form.
            decimal monthlyInvestment = Convert.ToDecimal(textBoxMonthlyInvestment.Text);
            decimal yearlyInterest = Convert.ToDecimal(textBoxYearlyInterestRate.Text);
            int years = Convert.ToInt16(textBoxNumberOfYears.Text);

            //2. Calculate Values in terms of months.
            decimal monthlyInterestRate = yearlyInterest / 12 / 100;
            int months = years * 12;

            //3. Calculate future value.
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            //4. Display Calculations
            textBoxFutureValue.Text = futureValue.ToString("c");
            textBoxMonthlyInvestment.Focus();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
