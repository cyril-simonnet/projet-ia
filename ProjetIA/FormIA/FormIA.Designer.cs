namespace FormIA
{
    partial class FormIA
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPresentation2 = new System.Windows.Forms.Label();
            this.btnQCM = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.lblPresentation1 = new System.Windows.Forms.Label();
            this.lblPresentation3 = new System.Windows.Forms.Label();
            this.gpQuestionnaire = new System.Windows.Forms.GroupBox();
            this.gpDijkstra = new System.Windows.Forms.GroupBox();
            this.gpQuestionnaire.SuspendLayout();
            this.gpDijkstra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPresentation2
            // 
            this.lblPresentation2.BackColor = System.Drawing.Color.Transparent;
            this.lblPresentation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPresentation2.Location = new System.Drawing.Point(1, 18);
            this.lblPresentation2.Name = "lblPresentation2";
            this.lblPresentation2.Size = new System.Drawing.Size(320, 88);
            this.lblPresentation2.TabIndex = 0;
            this.lblPresentation2.Text = "Exerce tes connaissances face à un questionnaire de 20 questions !";
            this.lblPresentation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQCM
            // 
            this.btnQCM.BackColor = System.Drawing.Color.SkyBlue;
            this.btnQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQCM.Location = new System.Drawing.Point(66, 127);
            this.btnQCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQCM.Name = "btnQCM";
            this.btnQCM.Size = new System.Drawing.Size(185, 65);
            this.btnQCM.TabIndex = 1;
            this.btnQCM.Text = "Questionnaire";
            this.btnQCM.UseVisualStyleBackColor = false;
            this.btnQCM.Click += new System.EventHandler(this.btnQCM_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDijkstra.Location = new System.Drawing.Point(47, 127);
            this.btnDijkstra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(219, 65);
            this.btnDijkstra.TabIndex = 2;
            this.btnDijkstra.Text = "Algorithme de Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = false;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btQuit.Location = new System.Drawing.Point(339, 374);
            this.btQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(203, 38);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "Quitter l\'évaluation";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // lblPresentation1
            // 
            this.lblPresentation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPresentation1.Location = new System.Drawing.Point(28, 20);
            this.lblPresentation1.Name = "lblPresentation1";
            this.lblPresentation1.Size = new System.Drawing.Size(814, 93);
            this.lblPresentation1.TabIndex = 0;
            this.lblPresentation1.Text = "Bienvenue jeune cogniticien ! Tu viens de t\'égarer dans le monde de l\'intelligenc" +
    "e artificielle !";
            this.lblPresentation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresentation3
            // 
            this.lblPresentation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPresentation3.Location = new System.Drawing.Point(22, 33);
            this.lblPresentation3.Name = "lblPresentation3";
            this.lblPresentation3.Size = new System.Drawing.Size(286, 59);
            this.lblPresentation3.TabIndex = 0;
            this.lblPresentation3.Text = "Teste tes capacités sur l\'algorithme de Dijkstra !";
            this.lblPresentation3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpQuestionnaire
            // 
            this.gpQuestionnaire.Controls.Add(this.btnQCM);
            this.gpQuestionnaire.Controls.Add(this.lblPresentation2);
            this.gpQuestionnaire.Location = new System.Drawing.Point(96, 129);
            this.gpQuestionnaire.Name = "gpQuestionnaire";
            this.gpQuestionnaire.Size = new System.Drawing.Size(321, 217);
            this.gpQuestionnaire.TabIndex = 4;
            this.gpQuestionnaire.TabStop = false;
            this.gpQuestionnaire.Text = "Questionnaire";
            // 
            // gpDijkstra
            // 
            this.gpDijkstra.Controls.Add(this.lblPresentation3);
            this.gpDijkstra.Controls.Add(this.btnDijkstra);
            this.gpDijkstra.Location = new System.Drawing.Point(473, 129);
            this.gpDijkstra.Name = "gpDijkstra";
            this.gpDijkstra.Size = new System.Drawing.Size(314, 217);
            this.gpDijkstra.TabIndex = 5;
            this.gpDijkstra.TabStop = false;
            this.gpDijkstra.Text = "Dijkstra";
            // 
            // FormIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 437);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.lblPresentation1);
            this.Controls.Add(this.gpQuestionnaire);
            this.Controls.Add(this.gpDijkstra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormIA";
            this.Text = "Evaluation des connaissances";
            this.gpQuestionnaire.ResumeLayout(false);
            this.gpDijkstra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPresentation2;
        private System.Windows.Forms.Button btnQCM;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lblPresentation1;
        private System.Windows.Forms.Label lblPresentation3;
        private System.Windows.Forms.GroupBox gpQuestionnaire;
        private System.Windows.Forms.GroupBox gpDijkstra;
    }
}

