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
        private const string _CHEMIN = "Questionnaire.xml"; //accès au fichier XML
        private int i = 0; //compteur pour affichage des questions
        public int scoreFinal = 0; //variable contenant le score du joueur au fil des questions
        public Questions questions; //créé une nouvelle liste de Question
        public Random random = new Random();
        public int randomChiffre;
        

        public FormQCM()
        {
            randomChiffre = random.Next(questions.Count); //nouveau random pour l'affichage des 23 questions possibles
            questions = new Questions();
            questions = Questions.Charger(_CHEMIN); //chargement de la liste de questions

            InitializeComponent();

            lblQ.Text = questions[randomChiffre].Intitule; //affiche l'intitulé d'une question en aléatoire
            lblAns1.Text = questions[randomChiffre].Reponse1.Intitule; //affiche la réponse 1 de la question aléatoire
            lblAns2.Text = questions[randomChiffre].Reponse2.Intitule; //affiche la réponse 2 de la question aléatoire
            lblAns3.Text = questions[randomChiffre].Reponse3.Intitule; //affiche la réponse 3 de la question aléatoire
            lblAns4.Text = questions[randomChiffre].Reponse4.Intitule; //affiche la réponse 4 de la question aléatoire
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (i<20)
            {
                questions.RemoveAt(randomChiffre); //à chaque fois qu'une question est posée, elle est retirée de la liste des possibles
                randomChiffre = random.Next(questions.Count-(i+1));

                lblQ.Text = questions[randomChiffre].Intitule; //nouvel affichage de question et de ses réponses
                lblAns1.Text = questions[randomChiffre].Reponse1.Intitule;
                lblAns2.Text = questions[randomChiffre].Reponse2.Intitule;
                lblAns3.Text = questions[randomChiffre].Reponse3.Intitule;
                lblAns4.Text = questions[randomChiffre].Reponse4.Intitule;

                i++;

                //vérifications du résultat de la question et incrémentation du score final en fonction
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
            
            else //affichage du message box avec possibilité de recommencer et affichage du score final
            {
                string message = "Votre score final est de " + scoreFinal + " !\nSi vous voulez recommencer, cliquez sur 'Recommencer'.\nSi vous voulez retourner à la page d'accueil, cliquez sur 'Annuler'.";
                string caption = "Résultat final";
                var result = MessageBox.Show(message,caption, MessageBoxButtons.RetryCancel);
                if(result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else if(result == DialogResult.Retry)
                {
                    this.Close();
                    FormQCM qcm = new FormQCM();
                    qcm.Show();
                }
            }
        }
    }
}
