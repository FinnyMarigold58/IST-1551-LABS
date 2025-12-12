namespace THLab2GUITranslator
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
            instructionLabel = new Label();
            translationLabel = new Label();
            spanishButton = new Button();
            germanButton = new Button();
            italianButton = new Button();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionLabel.Location = new Point(115, 32);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(333, 21);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            translationLabel.Location = new Point(102, 68);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(360, 36);
            translationLabel.TabIndex = 1;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(245, 117);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(75, 23);
            spanishButton.TabIndex = 2;
            spanishButton.Text = "Spanish";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(387, 117);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(75, 23);
            germanButton.TabIndex = 3;
            germanButton.Text = "German";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // italianButton
            // 
            italianButton.Location = new Point(102, 117);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(75, 23);
            italianButton.TabIndex = 4;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 163);
            Controls.Add(italianButton);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(translationLabel);
            Controls.Add(instructionLabel);
            Name = "Form1";
            Text = "Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private Label translationLabel;
        private Button spanishButton;
        private Button germanButton;
        private Button italianButton;
    }
}
