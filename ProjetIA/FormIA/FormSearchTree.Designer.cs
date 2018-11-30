namespace FormIA
{
    partial class FormSearchTree
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
            this.tv_DijkstraSolved = new System.Windows.Forms.TreeView();
            this.lbl_FermesGraphe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_DijkstraSolved = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_DijkstraSolved
            // 
            this.tv_DijkstraSolved.Location = new System.Drawing.Point(39, 66);
            this.tv_DijkstraSolved.Margin = new System.Windows.Forms.Padding(27, 4, 9, 4);
            this.tv_DijkstraSolved.Name = "tv_DijkstraSolved";
            this.tv_DijkstraSolved.Size = new System.Drawing.Size(256, 180);
            this.tv_DijkstraSolved.TabIndex = 19;
            // 
            // lbl_FermesGraphe
            // 
            this.lbl_FermesGraphe.AutoSize = true;
            this.lbl_FermesGraphe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FermesGraphe.Location = new System.Drawing.Point(36, 39);
            this.lbl_FermesGraphe.Name = "lbl_FermesGraphe";
            this.lbl_FermesGraphe.Size = new System.Drawing.Size(0, 17);
            this.lbl_FermesGraphe.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "TreeView";
            // 
            // lb_DijkstraSolved
            // 
            this.lb_DijkstraSolved.FormattingEnabled = true;
            this.lb_DijkstraSolved.ItemHeight = 16;
            this.lb_DijkstraSolved.Location = new System.Drawing.Point(349, 66);
            this.lb_DijkstraSolved.Margin = new System.Windows.Forms.Padding(4, 4, 27, 23);
            this.lb_DijkstraSolved.Name = "lb_DijkstraSolved";
            this.lb_DijkstraSolved.Size = new System.Drawing.Size(175, 180);
            this.lb_DijkstraSolved.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chemin Final";
            // 
            // FormSearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(580, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_DijkstraSolved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_FermesGraphe);
            this.Controls.Add(this.tv_DijkstraSolved);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSearchTree";
            this.Text = "Search Tree Answers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tv_DijkstraSolved;
        private System.Windows.Forms.Label lbl_FermesGraphe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_DijkstraSolved;
        private System.Windows.Forms.Label label3;
    }
}