﻿namespace FormIA
{
    partial class FormQCM
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.rbAns1 = new System.Windows.Forms.RadioButton();
            this.rbAns2 = new System.Windows.Forms.RadioButton();
            this.rbAns3 = new System.Windows.Forms.RadioButton();
            this.rbAns4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBienvenue.Location = new System.Drawing.Point(137, 38);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(359, 100);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue dans ce QCM. 20 questions vont t\'être posées, ta note sera donnée à la " +
    "fin. Bonne chance !";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ
            // 
            this.lblQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQ.Location = new System.Drawing.Point(64, 205);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(504, 23);
            this.lblQ.TabIndex = 1;
            // 
            // rbAns1
            // 
            this.rbAns1.AutoSize = true;
            this.rbAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns1.Location = new System.Drawing.Point(88, 266);
            this.rbAns1.Name = "rbAns1";
            this.rbAns1.Size = new System.Drawing.Size(17, 16);
            this.rbAns1.TabIndex = 2;
            this.rbAns1.TabStop = true;
            this.rbAns1.UseVisualStyleBackColor = true;
            // 
            // rbAns2
            // 
            this.rbAns2.AutoSize = true;
            this.rbAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns2.Location = new System.Drawing.Point(88, 298);
            this.rbAns2.Name = "rbAns2";
            this.rbAns2.Size = new System.Drawing.Size(17, 16);
            this.rbAns2.TabIndex = 2;
            this.rbAns2.TabStop = true;
            this.rbAns2.UseVisualStyleBackColor = true;
            // 
            // rbAns3
            // 
            this.rbAns3.AutoSize = true;
            this.rbAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns3.Location = new System.Drawing.Point(88, 330);
            this.rbAns3.Name = "rbAns3";
            this.rbAns3.Size = new System.Drawing.Size(17, 16);
            this.rbAns3.TabIndex = 2;
            this.rbAns3.TabStop = true;
            this.rbAns3.UseVisualStyleBackColor = true;
            // 
            // rbAns4
            // 
            this.rbAns4.AutoSize = true;
            this.rbAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns4.Location = new System.Drawing.Point(88, 361);
            this.rbAns4.Name = "rbAns4";
            this.rbAns4.Size = new System.Drawing.Size(17, 16);
            this.rbAns4.TabIndex = 2;
            this.rbAns4.TabStop = true;
            this.rbAns4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(458, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 549);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbAns4);
            this.Controls.Add(this.rbAns3);
            this.Controls.Add(this.rbAns2);
            this.Controls.Add(this.rbAns1);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblBienvenue);
            this.Name = "FormQCM";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.RadioButton rbAns1;
        private System.Windows.Forms.RadioButton rbAns2;
        private System.Windows.Forms.RadioButton rbAns3;
        private System.Windows.Forms.RadioButton rbAns4;
        private System.Windows.Forms.Button btnNext;
    }
}