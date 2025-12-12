// IST 1551, Lab 4, Tegan Herring, 10/03/2025
namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double foodCharge = double.Parse(foodChargeTextBox.Text);
            double tip = foodCharge * .15;
            double tax = foodCharge * .07;
            double total = foodCharge + tip + tax;

            tipLabel.Text = tip.ToString("C");
            taxLabel.Text = tax.ToString("C");
            totalLabel.Text = total.ToString("C");
        }
    }
}
