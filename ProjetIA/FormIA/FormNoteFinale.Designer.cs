﻿namespace FormIA
{
    partial class FormNoteFinale
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
            this.lblTxtScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblAbientot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTxtScore
            // 
            this.lblTxtScore.AutoSize = true;
            this.lblTxtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTxtScore.Location = new System.Drawing.Point(59, 58);
            this.lblTxtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxtScore.Name = "lblTxtScore";
            this.lblTxtScore.Size = new System.Drawing.Size(321, 25);
            this.lblTxtScore.TabIndex = 0;
            this.lblTxtScore.Text = "Vous avez obtenu le score suivant :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore.Location = new System.Drawing.Point(212, 125);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(2, 33);
            this.lblScore.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuit.Location = new System.Drawing.Point(161, 369);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 28);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblAbientot
            // 
            this.lblAbientot.AutoSize = true;
            this.lblAbientot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAbientot.Location = new System.Drawing.Point(78, 278);
            this.lblAbientot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbientot.Name = "lblAbientot";
            this.lblAbientot.Size = new System.Drawing.Size(307, 22);
            this.lblAbientot.TabIndex = 0;
            this.lblAbientot.Text = "A bientôt pour retanter votre chance !";
            // 
            // FormNoteFinale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 407);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAbientot);
            this.Controls.Add(this.lblTxtScore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNoteFinale";
            this.Text = "Résultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblAbientot;
    }
}