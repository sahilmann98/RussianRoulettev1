namespace RussianRoulette
{
    partial class Game
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
            this.radioPointTarget = new System.Windows.Forms.RadioButton();
            this.radioPointAway = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbRevolver = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // radioPointTarget
            // 
            this.radioPointTarget.AutoSize = true;
            this.radioPointTarget.Location = new System.Drawing.Point(225, 181);
            this.radioPointTarget.Name = "radioPointTarget";
            this.radioPointTarget.Size = new System.Drawing.Size(108, 21);
            this.radioPointTarget.TabIndex = 2;
            this.radioPointTarget.TabStop = true;
            this.radioPointTarget.Text = "Point at man";
            this.radioPointTarget.UseVisualStyleBackColor = true;
            // 
            // radioPointAway
            // 
            this.radioPointAway.AutoSize = true;
            this.radioPointAway.Location = new System.Drawing.Point(66, 181);
            this.radioPointAway.Name = "radioPointAway";
            this.radioPointAway.Size = new System.Drawing.Size(98, 21);
            this.radioPointAway.TabIndex = 3;
            this.radioPointAway.TabStop = true;
            this.radioPointAway.Text = "Point Away";
            this.radioPointAway.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(66, 224);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(267, 42);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "LOAD BULLET";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(66, 279);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(267, 42);
            this.btnSpin.TabIndex = 5;
            this.btnSpin.Text = "SPIN GUN CHAMBER";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(13, 351);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(573, 49);
            this.btnShoot.TabIndex = 6;
            this.btnShoot.Text = "FIRE";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Location = new System.Drawing.Point(12, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(573, 53);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT GAME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbRevolver
            // 
            this.pbRevolver.Image = global::RussianRoulette.Properties.Resources.revolver;
            this.pbRevolver.Location = new System.Drawing.Point(66, 22);
            this.pbRevolver.Name = "pbRevolver";
            this.pbRevolver.Size = new System.Drawing.Size(267, 153);
            this.pbRevolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRevolver.TabIndex = 1;
            this.pbRevolver.TabStop = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Image = global::RussianRoulette.Properties.Resources.person;
            this.pbTarget.Location = new System.Drawing.Point(430, 12);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(156, 309);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTarget.TabIndex = 0;
            this.pbTarget.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 479);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.radioPointAway);
            this.Controls.Add(this.radioPointTarget);
            this.Controls.Add(this.pbRevolver);
            this.Controls.Add(this.pbTarget);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbRevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.PictureBox pbRevolver;
        private System.Windows.Forms.RadioButton radioPointTarget;
        private System.Windows.Forms.RadioButton radioPointAway;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.Button btnSpin;
        public System.Windows.Forms.Button btnShoot;
    }
}

