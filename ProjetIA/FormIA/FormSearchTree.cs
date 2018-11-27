using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIA
{
    public partial class FormSearchTree : Form
    {
        public FormSearchTree()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) { e.Cancel = true; this.Hide(); } //ferme le form si on appuie sur la croix
            base.OnFormClosing(e);
        }

        public void AddLbDijkstraSolvedItem(string item) { lb_DijkstraSolved.Items.Add(item); } //ajoute les items justes à la solution valide

        public TreeView GetTv() { return tv_DijkstraSolved; } //récupère et affiche la vue treeview de l'arbre correct

    }
}
