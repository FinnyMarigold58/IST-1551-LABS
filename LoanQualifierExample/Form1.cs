using System;
using System.Windows.Forms;

namespace LoanQualifierExample
{
    public partial class Form1 : Form
    {
        // IST 1551, Lab #6, Tegan Herring 10/22/2025
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //two constants
            const decimal MINIMUM_SALARY = 40_000m;
            const int MINIMUM_YEARS = 2;

            //LOCAL VARAIBLES
            decimal salary = 0m;
            int yearsOnJob = 0;

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);
            } catch
            {
                MessageBox.Show("Invalid input");
            }

            //determine whether they user qualifies
            if (salary > MINIMUM_SALARY)
            {
                if (yearsOnJob > MINIMUM_YEARS)
                {
                    decisionLabel.Text = "You qualify for the loan";
                } else
                {
                    decisionLabel.Text = "Minimum years a t current job not met";
                }
                
            } else
            {
                // salary < 40k
                decisionLabel.Text = "Minimum salary requirement not met";
            }
        }
    }
}
