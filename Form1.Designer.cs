namespace assignment5_PavelGolovan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Garamond", 19F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(340, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guess what the number is?";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Font = new System.Drawing.Font("Garamond", 19F);
            this.guessTextBox.Location = new System.Drawing.Point(345, 88);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(303, 36);
            this.guessTextBox.TabIndex = 1;
            this.guessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Garamond", 19F);
            this.resultLabel.Location = new System.Drawing.Point(345, 127);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(303, 36);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessButton
            // 
            this.guessButton.AutoSize = true;
            this.guessButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.guessButton.Location = new System.Drawing.Point(448, 166);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(97, 39);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.clearButton.Location = new System.Drawing.Point(345, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 39);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.restartButton.Location = new System.Drawing.Point(551, 166);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(97, 39);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.exitButton.Location = new System.Drawing.Point(863, 286);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.Font = new System.Drawing.Font("Garamond", 19F);
            this.attemptsLabel.Location = new System.Drawing.Point(340, 47);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(308, 29);
            this.attemptsLabel.TabIndex = 7;
            this.attemptsLabel.Text = "Total attempts: 0";
            this.attemptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 337);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label attemptsLabel;
    }
}

