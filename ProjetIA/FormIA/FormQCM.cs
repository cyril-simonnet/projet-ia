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
        private int i = 0;
        public int scoreFinal = 0;

        public FormQCM()
        {
            Random random = new Random();
            int randomChiffre = random.Next(23);

            InitializeComponent();
            Questions questions = new Questions();
            questions = Questions.Charger(_CHEMIN);
            lblQ.Text = questions[randomChiffre].Intitule;
            lblAns1.Text = questions[randomChiffre].Reponse1.Intitule;
            lblAns2.Text = questions[randomChiffre].Reponse2.Intitule;
            lblAns3.Text = questions[randomChiffre].Reponse3.Intitule;
            lblAns4.Text = questions[randomChiffre].Reponse4.Intitule;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i<20)
            {
                Random random = new Random();
                int randomChiffre = random.Next(23);

                Questions questions = new Questions();
                questions = Questions.Charger(_CHEMIN);
                lblQ.Text = questions[randomChiffre].Intitule;
                lblAns1.Text = questions[randomChiffre].Reponse1.Intitule;
                lblAns2.Text = questions[randomChiffre].Reponse2.Intitule;
                lblAns3.Text = questions[randomChiffre].Reponse3.Intitule;
                lblAns4.Text = questions[randomChiffre].Reponse4.Intitule;

                i++;

                if((rbAns1.Checked == true) && (questions[randomChiffre].Reponse1.Value == true))
                {
                    scoreFinal++;
                }

                else if ((rbAns2.Checked == true) && (questions[randomChiffre].Reponse2.Value == true))
                {
                    scoreFinal++;
                }

                else if ((rbAns3.Checked == true) && (questions[randomChiffre].Reponse3.Value == true))
                {
                    scoreFinal++;
                }

                else if ((rbAns4.Checked == true) && (questions[randomChiffre].Reponse4.Value == true))
                {
                    scoreFinal++;
                }
            }
            
            else
            {
                MessageBox.Show("Votre score final est de : "+scoreFinal+", bravo !");
                //FormNoteFinale formNoteFinale = new FormNoteFinale();
                //formNoteFinale.Show();
            }

            //étape 1 : enregistrer la réponse donnée
            //étape 2 : afficher sur ce même form une nouvelle question en random --- OK
            //étape 3 : au 20ème click, faire apparaître le form associé --- OK
            //étape 4 : sur ce forme de résutlat, afficher le bon score
        }
    }
}
