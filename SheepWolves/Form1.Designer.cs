namespace SheepWolves
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
            this.playerNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // playerNumberNumeric
            // 
            this.playerNumberNumeric.Location = new System.Drawing.Point(12, 32);
            this.playerNumberNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerNumberNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.playerNumberNumeric.Name = "playerNumberNumeric";
            this.playerNumberNumeric.Size = new System.Drawing.Size(38, 20);
            this.playerNumberNumeric.TabIndex = 0;
            this.playerNumberNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many players?";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(56, 29);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game!";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 68);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerNumberNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "S vs W";
            ((System.ComponentModel.ISupportInitialize)(this.playerNumberNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown playerNumberNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startGameButton;
    }
}

