namespace LotteryNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int[] getRandom(int numberOfNumbers)
        {
            Random rand = new Random();
            int[] numbers = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {
                numbers[i] = rand.Next(10, 100);
            }

            return numbers;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int[] randomNumbers = getRandom(5);

            Label[] labels = {firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel};

            setLabels(labels, randomNumbers);
        }

        private void setLabels(Label[] labels, int[] randomNumbers)
        {
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                labels[i].Text = randomNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
