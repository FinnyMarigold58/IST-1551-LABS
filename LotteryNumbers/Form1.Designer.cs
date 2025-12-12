namespace LotteryNumbers
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
            firstLabel = new Label();
            generateButton = new Button();
            secondLabel = new Label();
            thirdLabel = new Label();
            fourthLabel = new Label();
            fifthLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // firstLabel
            // 
            firstLabel.BorderStyle = BorderStyle.Fixed3D;
            firstLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstLabel.Location = new Point(24, 18);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new Size(49, 38);
            firstLabel.TabIndex = 0;
            firstLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(80, 69);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(76, 49);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate Numbers";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // secondLabel
            // 
            secondLabel.BorderStyle = BorderStyle.Fixed3D;
            secondLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            secondLabel.Location = new Point(79, 18);
            secondLabel.Name = "secondLabel";
            secondLabel.Size = new Size(49, 38);
            secondLabel.TabIndex = 0;
            secondLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thirdLabel
            // 
            thirdLabel.BorderStyle = BorderStyle.Fixed3D;
            thirdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            thirdLabel.Location = new Point(134, 18);
            thirdLabel.Name = "thirdLabel";
            thirdLabel.Size = new Size(49, 38);
            thirdLabel.TabIndex = 0;
            thirdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fourthLabel
            // 
            fourthLabel.BorderStyle = BorderStyle.Fixed3D;
            fourthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fourthLabel.Location = new Point(189, 18);
            fourthLabel.Name = "fourthLabel";
            fourthLabel.Size = new Size(49, 38);
            fourthLabel.TabIndex = 0;
            fourthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fifthLabel
            // 
            fifthLabel.BorderStyle = BorderStyle.Fixed3D;
            fifthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            fifthLabel.Location = new Point(244, 18);
            fifthLabel.Name = "fifthLabel";
            fifthLabel.Size = new Size(49, 38);
            fifthLabel.TabIndex = 0;
            fifthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(162, 69);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(76, 49);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 137);
            Controls.Add(exitButton);
            Controls.Add(generateButton);
            Controls.Add(fifthLabel);
            Controls.Add(fourthLabel);
            Controls.Add(thirdLabel);
            Controls.Add(secondLabel);
            Controls.Add(firstLabel);
            Name = "Form1";
            Text = "Lottery Numbers";
            ResumeLayout(false);
        }

        #endregion

        private Label firstLabel;
        private Button generateButton;
        private Label secondLabel;
        private Label thirdLabel;
        private Label fourthLabel;
        private Label fifthLabel;
        private Button exitButton;
    }
}
