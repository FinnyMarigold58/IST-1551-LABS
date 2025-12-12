namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        private const int YARDS_TO_FEET = 3;
        private const int FOOT_TO_INCHES = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int inputDistance, convertedDistance = 0;

            // Try to parse input distance, else return error in MessageBox
            if (!int.TryParse(inputDistanceTextBox.Text, out inputDistance))
            {
                MessageBox.Show("Please input a valid integer into the distance textbox.");
                return;
            }

            string selectedFrom, selectedTo;
            // Set selected info, else return a MessageBox error
            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
            {
                selectedFrom = fromListBox.SelectedItem.ToString();
                selectedTo = toListBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Select To and From units");
                return;
            }



            if (selectedFrom == selectedTo)
            {
                convertedDistance = inputDistance;
            }
            else if (selectedFrom == "Inches")
            {
                switch (selectedTo)
                {
                    case "Feet":
                        convertedDistance = inputDistance / FOOT_TO_INCHES;
                        break;
                    case "Yards":
                        //                  inches        ->   feet       ->    yards
                        convertedDistance = inputDistance / FOOT_TO_INCHES / YARDS_TO_FEET;
                        break;
                }
            }
            else if (selectedFrom == "Feet")
            {
                switch (selectedTo)
                {
                    case "Inches":
                        //                  feet         -> inches
                        convertedDistance = inputDistance * FOOT_TO_INCHES;
                        break;
                    case "Yards":
                        //                  feet       ->    yards
                        convertedDistance = inputDistance / YARDS_TO_FEET;
                        break;
                }
            }
            else if (selectedFrom == "Yards")
            {
                switch (selectedTo)
                {
                    case "Feet":
                        convertedDistance = inputDistance * YARDS_TO_FEET;
                        break;
                    case "Inches":
                        //                  yards        ->   feet          -> inches
                        convertedDistance = inputDistance * YARDS_TO_FEET * FOOT_TO_INCHES;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Unknown From measurement");
            }

            outputLabel.Text = convertedDistance.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
