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
            this.components = new System.ComponentModel.Container();
            this.newGameButton = new System.Windows.Forms.Button();
            this.saveGameButton = new System.Windows.Forms.Button();
            this.playerNumberLabelStatic = new System.Windows.Forms.Label();
            this.playerNumberLabelDynamic = new System.Windows.Forms.Label();
            this.playerDeadNumberLabelDynamic = new System.Windows.Forms.Label();
            this.playerDeadNumberLabelStatic = new System.Windows.Forms.Label();
            this.playerPicture1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerPicture2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerPicture3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerPicture4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerPicture5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerPicture6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.playerPicture7 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.playerPicture8 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.playerPicture9 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.playerPicture10 = new System.Windows.Forms.PictureBox();
            this.deadList = new System.Windows.Forms.ListView();
            this.playerDeadLabel = new System.Windows.Forms.Label();
            this.playerNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.registerPlayerButton = new System.Windows.Forms.Button();
            this.playerAliveNumberLabelStatic = new System.Windows.Forms.Label();
            this.playerAliveNumberLabelDynamic = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture10)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(13, 13);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // saveGameButton
            // 
            this.saveGameButton.Location = new System.Drawing.Point(95, 12);
            this.saveGameButton.Name = "saveGameButton";
            this.saveGameButton.Size = new System.Drawing.Size(75, 23);
            this.saveGameButton.TabIndex = 1;
            this.saveGameButton.Text = "Save Game";
            this.saveGameButton.UseVisualStyleBackColor = true;
            this.saveGameButton.Click += new System.EventHandler(this.saveGameButton_Click);
            // 
            // playerNumberLabelStatic
            // 
            this.playerNumberLabelStatic.AutoSize = true;
            this.playerNumberLabelStatic.Location = new System.Drawing.Point(176, 17);
            this.playerNumberLabelStatic.Name = "playerNumberLabelStatic";
            this.playerNumberLabelStatic.Size = new System.Drawing.Size(96, 13);
            this.playerNumberLabelStatic.TabIndex = 2;
            this.playerNumberLabelStatic.Text = "Number of Players:";
            // 
            // playerNumberLabelDynamic
            // 
            this.playerNumberLabelDynamic.AutoSize = true;
            this.playerNumberLabelDynamic.Location = new System.Drawing.Point(278, 17);
            this.playerNumberLabelDynamic.Name = "playerNumberLabelDynamic";
            this.playerNumberLabelDynamic.Size = new System.Drawing.Size(13, 13);
            this.playerNumberLabelDynamic.TabIndex = 3;
            this.playerNumberLabelDynamic.Text = "0";
            this.playerNumberLabelDynamic.Visible = false;
            // 
            // playerDeadNumberLabelDynamic
            // 
            this.playerDeadNumberLabelDynamic.AutoSize = true;
            this.playerDeadNumberLabelDynamic.Location = new System.Drawing.Point(428, 18);
            this.playerDeadNumberLabelDynamic.Name = "playerDeadNumberLabelDynamic";
            this.playerDeadNumberLabelDynamic.Size = new System.Drawing.Size(13, 13);
            this.playerDeadNumberLabelDynamic.TabIndex = 5;
            this.playerDeadNumberLabelDynamic.Text = "0";
            // 
            // playerDeadNumberLabelStatic
            // 
            this.playerDeadNumberLabelStatic.AutoSize = true;
            this.playerDeadNumberLabelStatic.Location = new System.Drawing.Point(297, 17);
            this.playerDeadNumberLabelStatic.Name = "playerDeadNumberLabelStatic";
            this.playerDeadNumberLabelStatic.Size = new System.Drawing.Size(125, 13);
            this.playerDeadNumberLabelStatic.TabIndex = 4;
            this.playerDeadNumberLabelStatic.Text = "Number of Players Dead:";
            // 
            // playerPicture1
            // 
            this.playerPicture1.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture1.Location = new System.Drawing.Point(25, 76);
            this.playerPicture1.Name = "playerPicture1";
            this.playerPicture1.Size = new System.Drawing.Size(100, 100);
            this.playerPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture1.TabIndex = 6;
            this.playerPicture1.TabStop = false;
            this.playerPicture1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player 1 Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player 2 Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // playerPicture2
            // 
            this.playerPicture2.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture2.Location = new System.Drawing.Point(131, 76);
            this.playerPicture2.Name = "playerPicture2";
            this.playerPicture2.Size = new System.Drawing.Size(100, 100);
            this.playerPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture2.TabIndex = 8;
            this.playerPicture2.TabStop = false;
            this.playerPicture2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player 3 Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // playerPicture3
            // 
            this.playerPicture3.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture3.Location = new System.Drawing.Point(237, 76);
            this.playerPicture3.Name = "playerPicture3";
            this.playerPicture3.Size = new System.Drawing.Size(100, 100);
            this.playerPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture3.TabIndex = 10;
            this.playerPicture3.TabStop = false;
            this.playerPicture3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player 4 Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // playerPicture4
            // 
            this.playerPicture4.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture4.Location = new System.Drawing.Point(341, 76);
            this.playerPicture4.Name = "playerPicture4";
            this.playerPicture4.Size = new System.Drawing.Size(100, 100);
            this.playerPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture4.TabIndex = 12;
            this.playerPicture4.TabStop = false;
            this.playerPicture4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Player 5 Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // playerPicture5
            // 
            this.playerPicture5.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture5.Location = new System.Drawing.Point(447, 76);
            this.playerPicture5.Name = "playerPicture5";
            this.playerPicture5.Size = new System.Drawing.Size(100, 100);
            this.playerPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture5.TabIndex = 14;
            this.playerPicture5.TabStop = false;
            this.playerPicture5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Player 6 Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // playerPicture6
            // 
            this.playerPicture6.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture6.Location = new System.Drawing.Point(25, 195);
            this.playerPicture6.Name = "playerPicture6";
            this.playerPicture6.Size = new System.Drawing.Size(100, 100);
            this.playerPicture6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture6.TabIndex = 16;
            this.playerPicture6.TabStop = false;
            this.playerPicture6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Player 7 Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // playerPicture7
            // 
            this.playerPicture7.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture7.Location = new System.Drawing.Point(131, 195);
            this.playerPicture7.Name = "playerPicture7";
            this.playerPicture7.Size = new System.Drawing.Size(100, 100);
            this.playerPicture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture7.TabIndex = 18;
            this.playerPicture7.TabStop = false;
            this.playerPicture7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Player 8 Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // playerPicture8
            // 
            this.playerPicture8.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture8.Location = new System.Drawing.Point(237, 195);
            this.playerPicture8.Name = "playerPicture8";
            this.playerPicture8.Size = new System.Drawing.Size(100, 100);
            this.playerPicture8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture8.TabIndex = 20;
            this.playerPicture8.TabStop = false;
            this.playerPicture8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Player 9 Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Visible = false;
            // 
            // playerPicture9
            // 
            this.playerPicture9.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture9.Location = new System.Drawing.Point(343, 195);
            this.playerPicture9.Name = "playerPicture9";
            this.playerPicture9.Size = new System.Drawing.Size(100, 100);
            this.playerPicture9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture9.TabIndex = 22;
            this.playerPicture9.TabStop = false;
            this.playerPicture9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Player 10 Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            // 
            // playerPicture10
            // 
            this.playerPicture10.Image = global::SheepWolves.Properties.Resources.icon_quantumsheep;
            this.playerPicture10.Location = new System.Drawing.Point(449, 195);
            this.playerPicture10.Name = "playerPicture10";
            this.playerPicture10.Size = new System.Drawing.Size(100, 100);
            this.playerPicture10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture10.TabIndex = 24;
            this.playerPicture10.TabStop = false;
            this.playerPicture10.Visible = false;
            // 
            // deadList
            // 
            this.deadList.Location = new System.Drawing.Point(596, 76);
            this.deadList.Name = "deadList";
            this.deadList.Size = new System.Drawing.Size(175, 324);
            this.deadList.TabIndex = 26;
            this.deadList.UseCompatibleStateImageBehavior = false;
            // 
            // playerDeadLabel
            // 
            this.playerDeadLabel.AutoSize = true;
            this.playerDeadLabel.Location = new System.Drawing.Point(596, 57);
            this.playerDeadLabel.Name = "playerDeadLabel";
            this.playerDeadLabel.Size = new System.Drawing.Size(73, 13);
            this.playerDeadLabel.TabIndex = 27;
            this.playerDeadLabel.Text = "Dead Players:";
            // 
            // playerNumberInputTextBox
            // 
            this.playerNumberInputTextBox.Location = new System.Drawing.Point(270, 14);
            this.playerNumberInputTextBox.MaxLength = 2;
            this.playerNumberInputTextBox.Name = "playerNumberInputTextBox";
            this.playerNumberInputTextBox.Size = new System.Drawing.Size(20, 20);
            this.playerNumberInputTextBox.TabIndex = 28;
            this.playerNumberInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerNumberInputTextBox_KeyPress);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(38, 332);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 24);
            this.statusLabel.TabIndex = 29;
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(38, 360);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(100, 20);
            this.inputTextbox.TabIndex = 30;
            this.inputTextbox.Visible = false;
            this.inputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextbox_KeyPress);
            // 
            // registerPlayerButton
            // 
            this.registerPlayerButton.Location = new System.Drawing.Point(145, 356);
            this.registerPlayerButton.Name = "registerPlayerButton";
            this.registerPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.registerPlayerButton.TabIndex = 31;
            this.registerPlayerButton.Text = "Register Player";
            this.registerPlayerButton.UseVisualStyleBackColor = true;
            this.registerPlayerButton.Visible = false;
            this.registerPlayerButton.Click += new System.EventHandler(this.registerPlayerButton_Click);
            // 
            // playerAliveNumberLabelStatic
            // 
            this.playerAliveNumberLabelStatic.AutoSize = true;
            this.playerAliveNumberLabelStatic.Location = new System.Drawing.Point(447, 13);
            this.playerAliveNumberLabelStatic.Name = "playerAliveNumberLabelStatic";
            this.playerAliveNumberLabelStatic.Size = new System.Drawing.Size(122, 13);
            this.playerAliveNumberLabelStatic.TabIndex = 32;
            this.playerAliveNumberLabelStatic.Text = "Number of Players Alive:";
            // 
            // playerAliveNumberLabelDynamic
            // 
            this.playerAliveNumberLabelDynamic.AutoSize = true;
            this.playerAliveNumberLabelDynamic.Location = new System.Drawing.Point(576, 13);
            this.playerAliveNumberLabelDynamic.Name = "playerAliveNumberLabelDynamic";
            this.playerAliveNumberLabelDynamic.Size = new System.Drawing.Size(13, 13);
            this.playerAliveNumberLabelDynamic.TabIndex = 33;
            this.playerAliveNumberLabelDynamic.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 428);
            this.Controls.Add(this.playerAliveNumberLabelDynamic);
            this.Controls.Add(this.playerAliveNumberLabelStatic);
            this.Controls.Add(this.registerPlayerButton);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.playerNumberInputTextBox);
            this.Controls.Add(this.playerDeadLabel);
            this.Controls.Add(this.deadList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.playerPicture10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.playerPicture9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.playerPicture8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerPicture7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.playerPicture6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerPicture5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerPicture4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerPicture3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerPicture2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerPicture1);
            this.Controls.Add(this.playerDeadNumberLabelDynamic);
            this.Controls.Add(this.playerDeadNumberLabelStatic);
            this.Controls.Add(this.playerNumberLabelDynamic);
            this.Controls.Add(this.playerNumberLabelStatic);
            this.Controls.Add(this.saveGameButton);
            this.Controls.Add(this.newGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "S vs W";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button saveGameButton;
        private System.Windows.Forms.Label playerNumberLabelStatic;
        private System.Windows.Forms.Label playerNumberLabelDynamic;
        private System.Windows.Forms.Label playerDeadNumberLabelDynamic;
        private System.Windows.Forms.Label playerDeadNumberLabelStatic;
        private System.Windows.Forms.PictureBox playerPicture1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox playerPicture2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox playerPicture3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox playerPicture4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox playerPicture5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox playerPicture6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox playerPicture7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox playerPicture8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox playerPicture9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox playerPicture10;
        private System.Windows.Forms.ListView deadList;
        private System.Windows.Forms.Label playerDeadLabel;
        private System.Windows.Forms.TextBox playerNumberInputTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button registerPlayerButton;
        private System.Windows.Forms.Label playerAliveNumberLabelStatic;
        private System.Windows.Forms.Label playerAliveNumberLabelDynamic;
        private System.Windows.Forms.Timer timer1;

    }
}

