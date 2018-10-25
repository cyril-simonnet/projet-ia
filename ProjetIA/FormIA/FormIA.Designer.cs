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
            this.lblPresentation = new System.Windows.Forms.Label();
            this.btnQCM = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPresentation
            // 
            this.lblPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPresentation.Location = new System.Drawing.Point(159, 44);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(492, 198);
            this.lblPresentation.TabIndex = 0;
            this.lblPresentation.Text = "Bonjour jeune padawan ! Bienvenue dans le test de connaissances sur le module d\'I" +
    "A. Tu peux choisir le QCM, ou de tester notre algorithme de Djikstra :)";
            this.lblPresentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQCM
            // 
            this.btnQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQCM.Location = new System.Drawing.Point(164, 260);
            this.btnQCM.Name = "btnQCM";
            this.btnQCM.Size = new System.Drawing.Size(185, 65);
            this.btnQCM.TabIndex = 1;
            this.btnQCM.Text = "QCM";
            this.btnQCM.UseVisualStyleBackColor = true;
            this.btnQCM.Click += new System.EventHandler(this.btnQCM_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDijkstra.Location = new System.Drawing.Point(466, 260);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(185, 65);
            this.btnDijkstra.TabIndex = 2;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btQuit.Location = new System.Drawing.Point(343, 409);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(136, 38);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "Quitter";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // FormIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnQCM);
            this.Controls.Add(this.lblPresentation);
            this.Name = "FormIA";
            this.Text = "Evaluation des connaissances";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.Button btnQCM;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btQuit;
    }
}

