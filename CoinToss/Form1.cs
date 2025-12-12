using System.Diagnostics;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int random = rand.Next(2);

            if (random == 0)
            {
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                tailsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
