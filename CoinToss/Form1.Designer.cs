namespace CoinToss
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
            headsPictureBox = new PictureBox();
            tailsPictureBox = new PictureBox();
            tossButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headsPictureBox
            // 
            headsPictureBox.Image = Properties.Resources.Heads1;
            headsPictureBox.Location = new Point(26, 32);
            headsPictureBox.Name = "headsPictureBox";
            headsPictureBox.Size = new Size(170, 170);
            headsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headsPictureBox.TabIndex = 0;
            headsPictureBox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            tailsPictureBox.Image = Properties.Resources.Tails1_1;
            tailsPictureBox.Location = new Point(26, 32);
            tailsPictureBox.Name = "tailsPictureBox";
            tailsPictureBox.Size = new Size(170, 170);
            tailsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tailsPictureBox.TabIndex = 1;
            tailsPictureBox.TabStop = false;
            tailsPictureBox.Visible = false;
            // 
            // tossButton
            // 
            tossButton.Location = new Point(38, 224);
            tossButton.Name = "tossButton";
            tossButton.Size = new Size(75, 31);
            tossButton.TabIndex = 2;
            tossButton.Text = "Toss";
            tossButton.UseVisualStyleBackColor = true;
            tossButton.Click += tossButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(119, 224);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 31);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 267);
            Controls.Add(exitButton);
            Controls.Add(tossButton);
            Controls.Add(tailsPictureBox);
            Controls.Add(headsPictureBox);
            Name = "Form1";
            Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox headsPictureBox;
        private PictureBox tailsPictureBox;
        private Button tossButton;
        private Button exitButton;
    }
}
