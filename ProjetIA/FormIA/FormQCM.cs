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
    public partial class FormQCM : Form
    {
        int i = 0;
        int scoreFinal = 0;

        public FormQCM()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            //étape 1 : enregistrer la réponse donnée

            //étape 2 : afficher sur ce même form une nouvelle question en random
            Questions

            //étape 3 : au 20ème click, faire apparaître le form associé
            if (réponse correcte)
            {
                scoreFinal++;
            }

            FormNoteFinale formNoteFinale = new FormNoteFinale();
            formNoteFinale.Show();
           
        }
    }
}
