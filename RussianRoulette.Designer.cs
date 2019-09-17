namespace RussianRoulette
{
    partial class RussianRoulette
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
            this.pbRevolver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRevolver
            // 
            this.pbRevolver.Image = global::RussianRoulette.Properties.Resources.revolver;
            this.pbRevolver.Location = new System.Drawing.Point(12, 9);
            this.pbRevolver.Name = "pbRevolver";
            this.pbRevolver.Size = new System.Drawing.Size(232, 157);
            this.pbRevolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRevolver.TabIndex = 0;
            this.pbRevolver.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(456, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(251, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "RUSSIAN ROULETTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(314, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Name:";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(467, 143);
            this.boxName.Multiline = true;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(206, 30);
            this.boxName.TabIndex = 4;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(494, 211);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(139, 42);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Location = new System.Drawing.Point(494, 259);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(139, 42);
            this.btnExitMain.TabIndex = 6;
            this.btnExitMain.Text = "EXIT";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(705, 330);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRevolver);
            this.Name = "RussianRoulette";
            this.Text = "Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExitMain;
    }
}