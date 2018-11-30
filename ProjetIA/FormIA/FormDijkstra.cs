﻿using System;
using System.IO;
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
    public partial class FormDijkstra : Form
    {
        static public int[,] matrice; // matrice contenant l'arbre des possibles
        static public int nbNodes; // nombre de noeuds
        static public int numFinal; // numéro final de l'arbre
        private int numInitial; // numéro initial de l'arbre
        private string[] sep = { " " };
        private int iteInput = 1;
        private int iteInputGoal = -1;
        private SearchTree g; //nouveau searchtree
        private FormSearchTree answersForm; //nouveau form affichant la vision searchtree

        public FormDijkstra()
        {
            InitializeComponent();
        }

        private void DijkstraAForm_Load(object sender, EventArgs e)
        {
            this.answersForm = new FormSearchTree(); // Créé un nouveau formSearchTree
            ReadGraphFile();
            DijkstraASolverIterationDefiner();
            lbl_Instructions.Text = "Allez du point A au point E.";
            tb_OpenedPrevious.Text = g.L_OuvertsEvolution[0][0];
            lbl_IndicationsInput.Text = "Etape " + (this.iteInput + 1) + " de l'algorithme :";
            this.ActiveControl = tb_ClosedRead;
        }

        private void ReadGraphFile ()
        {            
            // Lecture du fichier
            StreamReader monStreamReader = new StreamReader("../../SujetGraph.txt");
            pb_graph.ImageLocation = "../../SujetGraph.png";
            numInitial = 0; numFinal = 4;

            // 1ère ligne : nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = ligne.IndexOf(':') + 1;
            string nbNodesString = "";
            while (i < ligne.Length)
            {
                nbNodesString = nbNodesString + ligne[i]; i++;
            }
            nbNodes = Convert.ToInt32(nbNodesString);

            matrice = new int[nbNodes, nbNodes];
            for (i = 0; i < nbNodes; i++)
                for (int j = 0; j < nbNodes; j++)
                    matrice[i, j] = -1;

            // Autres lignes : nodedépart nodearrivée valeur
            ligne = monStreamReader.ReadLine();
            int N1, N2, val; string strN1, strN2, strVal;
            while (ligne != null)
            {
                i = ligne.IndexOf(':') + 1;

                //nodedépart
                strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i]; i++;
                }
                N1 = Convert.ToInt32(strN1);

                //nodearrivée
                strN2 = ""; i++;
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i]; i++;
                }
                N2 = Convert.ToInt32(strN2);

                //valeur
                strVal = ""; i++;
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i]; i++;
                }
                val = Convert.ToInt32(strVal);

                //on enregistre les données dans la matrice
                matrice[N1, N2] = val;
                matrice[N2, N1] = val;

                ligne = monStreamReader.ReadLine();
            }

            monStreamReader.Close();
        }

        private void bt_ClosedOpenRead_Click(object sender, EventArgs e)
        {
            //On vérifie que l'input est étudiable
            if (!TextboxInputWorkable())
            {
                MessageBox.Show("Vous semblez avoir mal rempli vos cases.\n\nRappel :\n - La case \"Fermés\" ne sera jamais vide !\n - Les lettres doivent être en majuscule.\n - Si vous avez plusieurs lettres à rentrer, vous devez les séparer par \" \".");
                return;
            }
            //On vérifie que l'input est juste
            if (TextboxInputCorrect())
            {
                lbl_Correctness.Text = ""; System.Threading.Thread.Sleep(200);
                lbl_Correctness.Text = "Étape " + (this.iteInput+1) + " correcte !";
                lbl_IndicationsInput.Text = "Etape " + (this.iteInput+2) + " de l'algorithme :";
                iteInput++;
                tb_ClosedPrevious.Text = tb_ClosedRead.Text;
                tb_OpenedPrevious.Text = tb_OpenedRead.Text;
                if (iteInput == iteInputGoal)
                {
                    lbl_IndicationsInput.Text = "Fin de l'algorithme.";
                    MessageBox.Show("Dijkstra terminé !");
                }
            }
            else { MessageBox.Show("Erreur dans votre proposition !"); }
        }

        private bool TextboxInputWorkable ()
        {
            string txtF = tb_ClosedRead.Text;
            string txtO = tb_OpenedRead.Text;

            //Textbox Fermes vide ?
            if (txtF.Length == 0) { return false; }

            //Mauvaise séparations ?
            string[] txtFElements = txtF.Split(this.sep, StringSplitOptions.None);
            string[] txtOElements = txtO.Split(this.sep, StringSplitOptions.None);

            //Element length <= 0, >=2 ? Not maj or in alphabet ?
            foreach (string element in txtFElements)
            {
                if ((element.Length < 1) || (element.Length > 1)) { return false; }
                if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
            }
            if (txtO.Length != 0)
            {
                foreach (string element in txtOElements)
                {
                    if ((element.Length < 1) || (element.Length > 1)) { return false; }
                    if ((element.ToCharArray()[0] < 'A') || (element.ToCharArray()[0] > 'Z')) { return false; }
                }
            }

            return true;
        }

        private bool TextboxInputCorrect ()
        {
            string[] txtFElements = tb_ClosedRead.Text.Split(this.sep, StringSplitOptions.None);
            string[] txtOElements = tb_OpenedRead.Text.Split(this.sep, StringSplitOptions.None);

            foreach (string node in g.L_FermesEvolution[iteInput])
            {
                if (!txtFElements.Contains(node))
                {
                    return false;
                }
            }

            foreach (string node in g.L_OuvertsEvolution[iteInput])
            {
                if (!txtOElements.Contains(node))
                {
                    return false;
                }
            }

            return true;
        }

        private void DijkstraASolverIterationDefiner()
        {
            this.g = new SearchTree();
            SpecificNode N0 = new SpecificNode();
            N0.numero = numInitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0, this);

            SpecificNode N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                SpecificNode N2 = (SpecificNode)solution[i];
                answersForm.AddLbDijkstraSolvedItem(((char)(N1.numero + 65)).ToString() + " ---> " + ((char)(N2.numero + 65)).ToString() + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            this.g.GetSearchTree(answersForm.GetTv());
        }

        public void SetIterationInputGoal(int ite) { this.iteInputGoal = ite; }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.bt_ClosedOpenRead_Click(sender, new EventArgs());
                this.tb_ClosedRead.Focus();
            }
        }

        private void btnSearchT_Click(object sender, EventArgs e)
        {
            this.answersForm.Show();
        }
    }
}
