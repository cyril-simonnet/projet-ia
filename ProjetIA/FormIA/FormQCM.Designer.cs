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
            this.lblAns1 = new System.Windows.Forms.Label();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblAns3 = new System.Windows.Forms.Label();
            this.lblAns4 = new System.Windows.Forms.Label();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.gbQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(37, 38);
            this.lblBienvenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(639, 67);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "20 questions vont t\'être posées, ta note te sera donnée à la fin.\r\nBonne chance !" +
    "";
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ
            // 
            this.lblQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQ.Location = new System.Drawing.Point(16, 31);
            this.lblQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(575, 27);
            this.lblQ.TabIndex = 1;
            // 
            // rbAns1
            // 
            this.rbAns1.AutoSize = true;
            this.rbAns1.Checked = true;
            this.rbAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns1.Location = new System.Drawing.Point(37, 102);
            this.rbAns1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAns1.Name = "rbAns1";
            this.rbAns1.Size = new System.Drawing.Size(14, 13);
            this.rbAns1.TabIndex = 2;
            this.rbAns1.TabStop = true;
            this.rbAns1.UseVisualStyleBackColor = true;
            // 
            // rbAns2
            // 
            this.rbAns2.AutoSize = true;
            this.rbAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns2.Location = new System.Drawing.Point(37, 140);
            this.rbAns2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAns2.Name = "rbAns2";
            this.rbAns2.Size = new System.Drawing.Size(14, 13);
            this.rbAns2.TabIndex = 2;
            this.rbAns2.UseVisualStyleBackColor = true;
            // 
            // rbAns3
            // 
            this.rbAns3.AutoSize = true;
            this.rbAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns3.Location = new System.Drawing.Point(37, 178);
            this.rbAns3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAns3.Name = "rbAns3";
            this.rbAns3.Size = new System.Drawing.Size(14, 13);
            this.rbAns3.TabIndex = 2;
            this.rbAns3.UseVisualStyleBackColor = true;
            // 
            // rbAns4
            // 
            this.rbAns4.AutoSize = true;
            this.rbAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAns4.Location = new System.Drawing.Point(37, 215);
            this.rbAns4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAns4.Name = "rbAns4";
            this.rbAns4.Size = new System.Drawing.Size(14, 13);
            this.rbAns4.TabIndex = 2;
            this.rbAns4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(499, 446);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(176, 54);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Question suivante";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblAns1
            // 
            this.lblAns1.AutoSize = true;
            this.lblAns1.Location = new System.Drawing.Point(59, 102);
            this.lblAns1.Name = "lblAns1";
            this.lblAns1.Size = new System.Drawing.Size(0, 19);
            this.lblAns1.TabIndex = 4;
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Location = new System.Drawing.Point(59, 140);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(0, 19);
            this.lblAns2.TabIndex = 5;
            // 
            // lblAns3
            // 
            this.lblAns3.AutoSize = true;
            this.lblAns3.Location = new System.Drawing.Point(59, 178);
            this.lblAns3.Name = "lblAns3";
            this.lblAns3.Size = new System.Drawing.Size(0, 19);
            this.lblAns3.TabIndex = 6;
            // 
            // lblAns4
            // 
            this.lblAns4.AutoSize = true;
            this.lblAns4.Location = new System.Drawing.Point(59, 215);
            this.lblAns4.Name = "lblAns4";
            this.lblAns4.Size = new System.Drawing.Size(0, 19);
            this.lblAns4.TabIndex = 7;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.lblAns4);
            this.gbQuestion.Controls.Add(this.lblAns3);
            this.gbQuestion.Controls.Add(this.lblAns2);
            this.gbQuestion.Controls.Add(this.lblAns1);
            this.gbQuestion.Controls.Add(this.rbAns4);
            this.gbQuestion.Controls.Add(this.rbAns3);
            this.gbQuestion.Controls.Add(this.rbAns2);
            this.gbQuestion.Controls.Add(this.rbAns1);
            this.gbQuestion.Controls.Add(this.lblQ);
            this.gbQuestion.Location = new System.Drawing.Point(40, 126);
            this.gbQuestion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbQuestion.Size = new System.Drawing.Size(636, 282);
            this.gbQuestion.TabIndex = 8;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Question";
            // 
            // FormQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(719, 526);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblBienvenue);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormQCM";
            this.Text = "Questions";
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.RadioButton rbAns1;
        private System.Windows.Forms.RadioButton rbAns2;
        private System.Windows.Forms.RadioButton rbAns3;
        private System.Windows.Forms.RadioButton rbAns4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblAns1;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblAns3;
        private System.Windows.Forms.Label lblAns4;
        private System.Windows.Forms.GroupBox gbQuestion;
    }
}