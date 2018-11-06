using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace FormIA
{
    static class Program
    {
        //chemin de cration du fichier XML, ici dans le dossier du projet Visual Studio
        private const string _CHEMIN = "Questionnaire.xml";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIA());

            //fichier XML
            Questions questions = null;

            if (File.Exists(_CHEMIN))
            {
                questions = Questions.Charger(_CHEMIN);
            }
            else
            {
                questions = new Questions();
            }

            //Étapes ici.
            questions.Add(new Question(1, "Dans le cadre d'un graphe non orienté, la matrice d'adjacence est :", new Reponse(1, "Asymétrique", false), new Reponse(2,"Symétrique",true), new Reponse(3, "Ne peut pas être déterminée",false ), new Reponse(4, "Similaire à celle d'un graphe orienté", false)));

            //Sauvegarde
            questions.Enregistrer(_CHEMIN);
        }
    }
}
