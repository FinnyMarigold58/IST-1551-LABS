namespace TipTaxTotal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            foodChargeLabel = new Label();
            tipDescriptionLabel = new Label();
            taxDescriptionLabel = new Label();
            totalDescriptionLabel = new Label();
            tipLabel = new Label();
            taxLabel = new Label();
            totalLabel = new Label();
            foodChargeTextBox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // foodChargeLabel
            // 
            foodChargeLabel.AutoSize = true;
            foodChargeLabel.Location = new Point(28, 18);
            foodChargeLabel.Name = "foodChargeLabel";
            foodChargeLabel.Size = new Size(78, 15);
            foodChargeLabel.TabIndex = 0;
            foodChargeLabel.Text = "Food Charge:";
            // 
            // tipDescriptionLabel
            // 
            tipDescriptionLabel.AutoSize = true;
            tipDescriptionLabel.Location = new Point(50, 51);
            tipDescriptionLabel.Name = "tipDescriptionLabel";
            tipDescriptionLabel.Size = new Size(56, 15);
            tipDescriptionLabel.TabIndex = 1;
            tipDescriptionLabel.Text = "Tip (15%)";
            // 
            // taxDescriptionLabel
            // 
            taxDescriptionLabel.AutoSize = true;
            taxDescriptionLabel.Location = new Point(55, 85);
            taxDescriptionLabel.Name = "taxDescriptionLabel";
            taxDescriptionLabel.Size = new Size(51, 15);
            taxDescriptionLabel.TabIndex = 2;
            taxDescriptionLabel.Text = "Tax (7%)";
            // 
            // totalDescriptionLabel
            // 
            totalDescriptionLabel.AutoSize = true;
            totalDescriptionLabel.Location = new Point(74, 118);
            totalDescriptionLabel.Name = "totalDescriptionLabel";
            totalDescriptionLabel.Size = new Size(32, 15);
            totalDescriptionLabel.TabIndex = 3;
            totalDescriptionLabel.Text = "Total";
            // 
            // tipLabel
            // 
            tipLabel.BorderStyle = BorderStyle.FixedSingle;
            tipLabel.Location = new Point(112, 46);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(95, 24);
            tipLabel.TabIndex = 4;
            tipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            taxLabel.BorderStyle = BorderStyle.FixedSingle;
            taxLabel.Location = new Point(112, 81);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(95, 23);
            taxLabel.TabIndex = 5;
            taxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLabel.Location = new Point(112, 113);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(95, 25);
            totalLabel.TabIndex = 6;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodChargeTextBox
            // 
            foodChargeTextBox.Location = new Point(112, 15);
            foodChargeTextBox.Name = "foodChargeTextBox";
            foodChargeTextBox.Size = new Size(95, 23);
            foodChargeTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(32, 151);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(132, 151);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 202);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(foodChargeTextBox);
            Controls.Add(totalLabel);
            Controls.Add(taxLabel);
            Controls.Add(tipLabel);
            Controls.Add(totalDescriptionLabel);
            Controls.Add(taxDescriptionLabel);
            Controls.Add(tipDescriptionLabel);
            Controls.Add(foodChargeLabel);
            Name = "Form1";
            Text = "Tip Tax and Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label foodChargeLabel;
        private Label tipDescriptionLabel;
        private Label taxDescriptionLabel;
        private Label totalDescriptionLabel;
        private Label tipLabel;
        private Label taxLabel;
        private Label totalLabel;
        private TextBox foodChargeTextBox;
        private Button calculateButton;
        private Button exitButton;
    }
}
