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
        private const string _CHEMIN = "Questionnaire.xml";
        int i = 0;
        int scoreFinal = 0;

        public FormQCM()
        {
            InitializeComponent();
            Questions questions = new Questions();
            questions = Questions.Charger(_CHEMIN);
            lblQ.Text = questions[1].Intitule;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            questions = Questions.Charger(_CHEMIN);
            lblQ.Text = questions[5].Intitule;

            if (i<20)
            {
                FormQCM formQCM = new FormQCM();
                formQCM.Show();
            }
            else
            {
                FormNoteFinale formNoteFinale = new FormNoteFinale();
                formNoteFinale.Show();
            }

            i++;
            scoreFinal++;

            //étape 1 : enregistrer la réponse donnée
            //étape 2 : afficher sur ce même form une nouvelle question en random
            //étape 3 : au 20ème click, faire apparaître le form associé        
        }
    }
}
