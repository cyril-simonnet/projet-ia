﻿using System;
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
                //scoreFinal++;
            }
            
            else
            {
                FormNoteFinale formNoteFinale = new FormNoteFinale();
                formNoteFinale.Show();
            }

            //étape 1 : enregistrer la réponse donnée
            //étape 2 : afficher sur ce même form une nouvelle question en random
            //étape 3 : au 20ème click, faire apparaître le form associé        
        }
    }
}
