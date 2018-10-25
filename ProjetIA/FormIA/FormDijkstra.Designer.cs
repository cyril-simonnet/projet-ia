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
            this.lblDijkstra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDijkstra
            // 
            this.lblDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDijkstra.Location = new System.Drawing.Point(105, 63);
            this.lblDijkstra.Name = "lblDijkstra";
            this.lblDijkstra.Size = new System.Drawing.Size(499, 102);
            this.lblDijkstra.TabIndex = 0;
            this.lblDijkstra.Text = "Bienvenue dans Dijkstra ! Essayes de trouver le plus court chemin, et notre algor" +
    "ithme vérifiera ta réponse !";
            this.lblDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 622);
            this.Controls.Add(this.lblDijkstra);
            this.Name = "FormDijkstra";
            this.Text = "Résolution Dijkstra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDijkstra;
    }
}