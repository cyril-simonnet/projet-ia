namespace FormIA
{
    partial class FormDijkstra
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
            this.tb_ClosedRead = new System.Windows.Forms.TextBox();
            this.tb_OpenedRead = new System.Windows.Forms.TextBox();
            this.tb_ClosedPrevious = new System.Windows.Forms.TextBox();
            this.tb_OpenedPrevious = new System.Windows.Forms.TextBox();
            this.lbl_ClosedPrevious = new System.Windows.Forms.Label();
            this.lbl_ClosedRead = new System.Windows.Forms.Label();
            this.lbl_OpenedPrevious = new System.Windows.Forms.Label();
            this.lbl_OpenedRead = new System.Windows.Forms.Label();
            this.bt_ClosedOpenRead = new System.Windows.Forms.Button();
            this.pb_graph = new System.Windows.Forms.PictureBox();
            this.lbl_Correctness = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.btnSearchT = new System.Windows.Forms.Button();
            this.lblBienvenueDij = new System.Windows.Forms.Label();
            this.lbl_IndicationsInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ClosedRead
            // 
            this.tb_ClosedRead.Location = new System.Drawing.Point(327, 370);
            this.tb_ClosedRead.Margin = new System.Windows.Forms.Padding(3, 4, 23, 4);
            this.tb_ClosedRead.Name = "tb_ClosedRead";
            this.tb_ClosedRead.Size = new System.Drawing.Size(234, 27);
            this.tb_ClosedRead.TabIndex = 3;
            // 
            // tb_OpenedRead
            // 
            this.tb_OpenedRead.Location = new System.Drawing.Point(327, 468);
            this.tb_OpenedRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OpenedRead.Name = "tb_OpenedRead";
            this.tb_OpenedRead.Size = new System.Drawing.Size(234, 27);
            this.tb_OpenedRead.TabIndex = 4;
            this.tb_OpenedRead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // tb_ClosedPrevious
            // 
            this.tb_ClosedPrevious.Location = new System.Drawing.Point(23, 370);
            this.tb_ClosedPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ClosedPrevious.Name = "tb_ClosedPrevious";
            this.tb_ClosedPrevious.ReadOnly = true;
            this.tb_ClosedPrevious.Size = new System.Drawing.Size(234, 27);
            this.tb_ClosedPrevious.TabIndex = 5;
            // 
            // tb_OpenedPrevious
            // 
            this.tb_OpenedPrevious.Location = new System.Drawing.Point(23, 468);
            this.tb_OpenedPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_OpenedPrevious.Name = "tb_OpenedPrevious";
            this.tb_OpenedPrevious.ReadOnly = true;
            this.tb_OpenedPrevious.Size = new System.Drawing.Size(234, 27);
            this.tb_OpenedPrevious.TabIndex = 6;
            // 
            // lbl_ClosedPrevious
            // 
            this.lbl_ClosedPrevious.AutoSize = true;
            this.lbl_ClosedPrevious.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosedPrevious.Location = new System.Drawing.Point(22, 338);
            this.lbl_ClosedPrevious.Name = "lbl_ClosedPrevious";
            this.lbl_ClosedPrevious.Size = new System.Drawing.Size(122, 19);
            this.lbl_ClosedPrevious.TabIndex = 7;
            this.lbl_ClosedPrevious.Text = " Fermés (précédent)";
            // 
            // lbl_ClosedRead
            // 
            this.lbl_ClosedRead.AutoSize = true;
            this.lbl_ClosedRead.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClosedRead.Location = new System.Drawing.Point(322, 338);
            this.lbl_ClosedRead.Name = "lbl_ClosedRead";
            this.lbl_ClosedRead.Size = new System.Drawing.Size(50, 19);
            this.lbl_ClosedRead.TabIndex = 8;
            this.lbl_ClosedRead.Text = "Fermés";
            // 
            // lbl_OpenedPrevious
            // 
            this.lbl_OpenedPrevious.AutoSize = true;
            this.lbl_OpenedPrevious.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenedPrevious.Location = new System.Drawing.Point(23, 436);
            this.lbl_OpenedPrevious.Name = "lbl_OpenedPrevious";
            this.lbl_OpenedPrevious.Size = new System.Drawing.Size(121, 19);
            this.lbl_OpenedPrevious.TabIndex = 9;
            this.lbl_OpenedPrevious.Text = "Ouverts (précédent)";
            // 
            // lbl_OpenedRead
            // 
            this.lbl_OpenedRead.AutoSize = true;
            this.lbl_OpenedRead.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenedRead.Location = new System.Drawing.Point(322, 436);
            this.lbl_OpenedRead.Name = "lbl_OpenedRead";
            this.lbl_OpenedRead.Size = new System.Drawing.Size(53, 19);
            this.lbl_OpenedRead.TabIndex = 10;
            this.lbl_OpenedRead.Text = "Ouverts";
            // 
            // bt_ClosedOpenRead
            // 
            this.bt_ClosedOpenRead.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ClosedOpenRead.Location = new System.Drawing.Point(453, 595);
            this.bt_ClosedOpenRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 28);
            this.bt_ClosedOpenRead.Name = "bt_ClosedOpenRead";
            this.bt_ClosedOpenRead.Size = new System.Drawing.Size(115, 34);
            this.bt_ClosedOpenRead.TabIndex = 11;
            this.bt_ClosedOpenRead.Text = "Valider";
            this.bt_ClosedOpenRead.UseVisualStyleBackColor = true;
            this.bt_ClosedOpenRead.Click += new System.EventHandler(this.bt_ClosedOpenRead_Click);
            // 
            // pb_graph
            // 
            this.pb_graph.Location = new System.Drawing.Point(43, 107);
            this.pb_graph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(486, 190);
            this.pb_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_graph.TabIndex = 12;
            this.pb_graph.TabStop = false;
            // 
            // lbl_Correctness
            // 
            this.lbl_Correctness.AutoSize = true;
            this.lbl_Correctness.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correctness.Location = new System.Drawing.Point(90, 533);
            this.lbl_Correctness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Correctness.Name = "lbl_Correctness";
            this.lbl_Correctness.Size = new System.Drawing.Size(0, 19);
            this.lbl_Correctness.TabIndex = 13;
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.Location = new System.Drawing.Point(194, 66);
            this.lbl_Instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(0, 13);
            this.lbl_Instructions.TabIndex = 16;
            // 
            // btnSearchT
            // 
            this.btnSearchT.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchT.Location = new System.Drawing.Point(18, 595);
            this.btnSearchT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchT.Name = "btnSearchT";
            this.btnSearchT.Size = new System.Drawing.Size(197, 34);
            this.btnSearchT.TabIndex = 18;
            this.btnSearchT.Text = "Réponses Vue Search Tree";
            this.btnSearchT.UseVisualStyleBackColor = true;
            this.btnSearchT.Click += new System.EventHandler(this.btnSearchT_Click);
            // 
            // lblBienvenueDij
            // 
            this.lblBienvenueDij.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueDij.Location = new System.Drawing.Point(14, 13);
            this.lblBienvenueDij.Name = "lblBienvenueDij";
            this.lblBienvenueDij.Size = new System.Drawing.Size(554, 91);
            this.lblBienvenueDij.TabIndex = 19;
            this.lblBienvenueDij.Text = "Bienvenue dans cet algorithme de Dijkstra ! Essaye de trouver le meilleur chemin," +
    " étape par étape...";
            this.lblBienvenueDij.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_IndicationsInput
            // 
            this.lbl_IndicationsInput.AutoSize = true;
            this.lbl_IndicationsInput.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndicationsInput.Location = new System.Drawing.Point(321, 300);
            this.lbl_IndicationsInput.Name = "lbl_IndicationsInput";
            this.lbl_IndicationsInput.Size = new System.Drawing.Size(0, 19);
            this.lbl_IndicationsInput.TabIndex = 14;
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(582, 642);
            this.Controls.Add(this.lblBienvenueDij);
            this.Controls.Add(this.btnSearchT);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.lbl_IndicationsInput);
            this.Controls.Add(this.lbl_Correctness);
            this.Controls.Add(this.pb_graph);
            this.Controls.Add(this.bt_ClosedOpenRead);
            this.Controls.Add(this.lbl_OpenedRead);
            this.Controls.Add(this.lbl_OpenedPrevious);
            this.Controls.Add(this.lbl_ClosedRead);
            this.Controls.Add(this.lbl_ClosedPrevious);
            this.Controls.Add(this.tb_OpenedPrevious);
            this.Controls.Add(this.tb_ClosedPrevious);
            this.Controls.Add(this.tb_OpenedRead);
            this.Controls.Add(this.tb_ClosedRead);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDijkstra";
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.DijkstraAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_ClosedRead;
        private System.Windows.Forms.TextBox tb_OpenedRead;
        private System.Windows.Forms.TextBox tb_ClosedPrevious;
        private System.Windows.Forms.TextBox tb_OpenedPrevious;
        private System.Windows.Forms.Label lbl_ClosedPrevious;
        private System.Windows.Forms.Label lbl_ClosedRead;
        private System.Windows.Forms.Label lbl_OpenedPrevious;
        private System.Windows.Forms.Label lbl_OpenedRead;
        private System.Windows.Forms.Button bt_ClosedOpenRead;
        private System.Windows.Forms.PictureBox pb_graph;
        private System.Windows.Forms.Label lbl_Correctness;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.Button btnSearchT;
        private System.Windows.Forms.Label lblBienvenueDij;
        private System.Windows.Forms.Label lbl_IndicationsInput;
    }
}