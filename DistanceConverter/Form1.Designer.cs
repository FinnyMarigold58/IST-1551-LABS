namespace DistanceConverter
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
            label1 = new Label();
            inputDistanceTextBox = new TextBox();
            groupBox1 = new GroupBox();
            fromListBox = new ListBox();
            groupBox2 = new GroupBox();
            toListBox = new ListBox();
            label2 = new Label();
            outputLabel = new Label();
            convertButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 38);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a distance to convert:";
            // 
            // inputDistanceTextBox
            // 
            inputDistanceTextBox.Location = new Point(271, 30);
            inputDistanceTextBox.Name = "inputDistanceTextBox";
            inputDistanceTextBox.Size = new Size(100, 23);
            inputDistanceTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromListBox);
            groupBox1.Location = new Point(18, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 114);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // fromListBox
            // 
            fromListBox.FormattingEnabled = true;
            fromListBox.ItemHeight = 15;
            fromListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromListBox.Location = new Point(34, 32);
            fromListBox.Name = "fromListBox";
            fromListBox.Size = new Size(120, 64);
            fromListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toListBox);
            groupBox2.Location = new Point(247, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 114);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // toListBox
            // 
            toListBox.FormattingEnabled = true;
            toListBox.ItemHeight = 15;
            toListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toListBox.Location = new Point(34, 32);
            toListBox.Name = "toListBox";
            toListBox.Size = new Size(120, 64);
            toListBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 220);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter a distance to convert:";
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(271, 216);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(100, 23);
            outputLabel.TabIndex = 5;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(151, 256);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 6;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(232, 256);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 313);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(outputLabel);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(inputDistanceTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Distance Converter";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputDistanceTextBox;
        private GroupBox groupBox1;
        private ListBox fromListBox;
        private GroupBox groupBox2;
        private ListBox toListBox;
        private Label label2;
        private Label outputLabel;
        private Button convertButton;
        private Button exitButton;
    }
}
