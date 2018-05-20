namespace Tic_Tac_Toe_AI_Game
{
    partial class Form2
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
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.checkBoxAgainstThePC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(10, 11);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(90, 13);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "Player One Name";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(10, 41);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(91, 13);
            this.playerTwoLabel.TabIndex = 1;
            this.playerTwoLabel.Text = "Player Two Name";
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(106, 38);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(242, 20);
            this.playerTwoTextBox.TabIndex = 3;
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Location = new System.Drawing.Point(106, 8);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(242, 20);
            this.playerOneTextBox.TabIndex = 2;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(273, 64);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // checkBoxAgainstThePC
            // 
            this.checkBoxAgainstThePC.AutoSize = true;
            this.checkBoxAgainstThePC.Location = new System.Drawing.Point(12, 68);
            this.checkBoxAgainstThePC.Name = "checkBoxAgainstThePC";
            this.checkBoxAgainstThePC.Size = new System.Drawing.Size(127, 17);
            this.checkBoxAgainstThePC.TabIndex = 5;
            this.checkBoxAgainstThePC.Text = "Against the Computer";
            this.checkBoxAgainstThePC.UseVisualStyleBackColor = true;
            this.checkBoxAgainstThePC.CheckedChanged += new System.EventHandler(this.checkBoxAgainstThePC_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 97);
            this.Controls.Add(this.checkBoxAgainstThePC);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.playerOneTextBox);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.CheckBox checkBoxAgainstThePC;
    }
}