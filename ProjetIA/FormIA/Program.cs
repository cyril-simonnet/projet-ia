using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace FormIA
{
    public static class Program
    {
        //chemin de cration du fichier XML, ici dans le dossier du projet Visual Studio
        private const string _CHEMIN = "Questionnaire.xml";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        
        [STAThread]
        public static void Main()
        {
            //fichier XML
            Questions questions = null;

            if (File.Exists(_CHEMIN))
            {
                questions = Questions.Charger(_CHEMIN);
            }
            else
            {
                questions = new Questions();
                //Étapes ici.
                questions.Add(new Question(1, "La différence entre IA faible et IA forte est d’ordre :", new Reponse(1, "Technique : l’IA faible est moins aboutie que l’IA forte", false), new Reponse(2, "Technique : l’IA faible est plus aboutie que l’IA forte", false), new Reponse(3, "Conceptuelle : ce sont deux façons de concevoir l’IA", true), new Reponse(4, "Il n’y a aucune différence, ces termes désignent la même chose", false)));
                questions.Add(new Question(2, "Dans le cadre d'un graphe non orienté, la matrice d'adjacence est :", new Reponse(1, "Asymétrique", false), new Reponse(2, "Symétrique", true), new Reponse(3, "Ne peut pas être déterminée", false), new Reponse(4, "Similaire à celle d'un graphe orienté", false)));
                questions.Add(new Question(3, "Dans la théorie des jeux, un des principes de base est :", new Reponse(1, "De supposer que l’adversaire joue de façon optimale", true), new Reponse(2, "De supposer que le nombre de coups possibles est fini", false), new Reponse(3, "De descendre progressivement dans l'arborescence des coups possibles", false), new Reponse(4, "De supposer que l’adversaire va faire des erreurs", false)));
                questions.Add(new Question(4, "Comparé à Min-Max, l'algorithme Alpha-Beta :", new Reponse(1, "N’a rien à voir, ce sont deux méthodes différentes", false), new Reponse(2, "Est identique, mais permet d’ajouter des branches optionnelles", false), new Reponse(3, "Est identique, mais permet d’éviter les branches inutiles", true), new Reponse(4, "Ne se code pas dans le même langage", false)));
                questions.Add(new Question(5, "L’algorithme de Dijkstra permet :", new Reponse(1, "De trouver le plus court chemin parmi une liste de possibilités finie", true), new Reponse(2, "De déterminer si une liste de possibilité est finie ou infinie", false), new Reponse(3, "De trouver le plus court chemin parmi une liste de possibilités infinie", false), new Reponse(4, "De valider le fait qu’une liste de possibilité soit finie", false)));
                questions.Add(new Question(6, "L’algorithme A* :", new Reponse(1, "Est identique à celui de Dijkstra en tous points", false), new Reponse(2, "Est identique à celui de Dijkstra, sauf pour les noeuds fermés", false), new Reponse(3, "Est identique à celui de Dijkstra, sauf pour les noeuds ouverts", true), new Reponse(4, "Diffère entièrement de celui de Dijkstra", false)));
                questions.Add(new Question(7, "L’ajout d’une heuristique h(N) dans l’algorithme A* permet :", new Reponse(1, "D’estimer les erreurs que l’IA pourrait commettre", false), new Reponse(2, "D’estimer le coût restant pour atteindre un but fixé", true), new Reponse(3, "De prédire le comportement du système étudié", false), new Reponse(4, "Aucune de ces réponses", false)));
                questions.Add(new Question(8, "Dans quel cas serait-il pertinent de ne pas choisir de minorant h(N) avec Dijkstra ?", new Reponse(1, "Si trop de paramètres nous sont encore inconnus", false), new Reponse(2, "Si l’on souhaite trouver la meilleure solution possible", false), new Reponse(3, "Si l’on souhaite exclure la moins bonne solution", false), new Reponse(4, "Si l’on souhaite trouver une solution dans un temps raisonnable", true)));
                questions.Add(new Question(9, "Dans le problème du voyageur de commerce, l’espace des états correspond :", new Reponse(1, "A l’ensemble des villes et leurs distances entre elles", true), new Reponse(2, "Aux distances entre les villes", false), new Reponse(3, "Aux villes elles-mêmes", false), new Reponse(4, "On ne peut pas définir d’espace des états pour ce problème", false)));
                questions.Add(new Question(10, "Actuellement, l’IA est :", new Reponse(1, "Une simulation de l’intelligence", false), new Reponse(2, "De l’intelligence réelle", false), new Reponse(3, "Semblable à l’intelligence réelle", false), new Reponse(4, "Aucun consensus n’a encore été validé", true)));
                questions.Add(new Question(11, "Comparé au “model based”, le “data based” est :", new Reponse(1, "La même chose, mais en plus abouti", false), new Reponse(2, "Basé sur un modèle de connaissance", false), new Reponse(3, "Basé sur un grand nombre de données", true), new Reponse(4, "Complètement différent", false)));
                questions.Add(new Question(12, "Quel thème ne fait pas partie du domaine de l’IA aujourd’hui ?", new Reponse(1, "Quel thème ne fait pas partie du domaine de l’IA aujourd’hui ?", false), new Reponse(2, "La sémantique", true), new Reponse(3, "Les arbres de décision", false), new Reponse(4, "La planification", false)));
                questions.Add(new Question(13, "Dans une représentation en graphe, un noeud est :", new Reponse(1, "L’opposé d’un sommet", false), new Reponse(2, "La même chose qu’un sommet", true), new Reponse(3, "Il n’y a pas de noeuds lorsque l’on parle de représentation en graphe", false), new Reponse(4, "A l’intersection de deux sommets", false)));
                questions.Add(new Question(14, "Dans une matrice d’adjacence, lorsqu’il n’y a pas d’arrête :", new Reponse(1, "On remplace toujours par la valeur 0", false), new Reponse(2, "On remplace toujours par la valeur -1", false), new Reponse(3, "Cela ne peut jamais arriver", false), new Reponse(4, "On remplace par une valeur conventionnelle", true)));
                questions.Add(new Question(15, "Déterminez quelle réponse est erronée.", new Reponse(1, "Un graphe n’est pas toujours orienté", false), new Reponse(2, "L’algorithme A* est une forme plus aboutie de celui de Dijkstra", false), new Reponse(3, "En IA, tous les problèmes peuvent être rapportés à un algorithme de Dijkstra", true), new Reponse(4, "Une heuristique permet de réduire les temps de calcul", false)));
                questions.Add(new Question(16, "La fonction f(N) se décompose en :", new Reponse(1, "coût_chemin (N) + h(N)", true), new Reponse(2, "coût_chemin (N) - h(N)", false), new Reponse(3, "coût_chemin (N) / h(N)", false), new Reponse(4, "coût_chemin (N) * h(N)", false)));
                questions.Add(new Question(17, "Si h(N) minore le coût du chemin restant réel, alors :", new Reponse(1, "L’algorithme ne peut rien conclure", false), new Reponse(2, "A* garantit que le chemin trouvé sera le plus court", true), new Reponse(3, "La marge d’erreur sera égale à h(N)", false), new Reponse(4, "La valeur majorante sera h’(N)", false)));
                questions.Add(new Question(18, "Enlever une heuristique consiste à :", new Reponse(1, "Traduire le problème dans un sens plus compréhensible pour la machine", false), new Reponse(2, "Écarter une contrainte du problème pour qu'il devienne plus facile", true), new Reponse(3, "Déterminer quels points clefs posent le plus problème", false), new Reponse(4, "Retirer du problème une solution évidente pour gagner du temps", false)));
                questions.Add(new Question(19, "L’arbre d’exploration correspond à :", new Reponse(1, "La totalité des possibilités explorées par l’algorithme", false), new Reponse(2, "La totalité des possibilités d’exploration de l’algorithme", true), new Reponse(3, "L’espace des états", false), new Reponse(4, "L’ordre dans lequel les possibilités vont être explorées", false)));
                questions.Add(new Question(20, "Dijkstra est un algorithme à exploration :", new Reponse(1, "Sinusoïdale", false), new Reponse(2, "Pyramidale", false), new Reponse(3, "Radiale", true), new Reponse(4, "Peut prendre chacune de ces formes", false)));
                questions.Add(new Question(21, "Dans le jeu du taquin, l’espace des états peut être représenté par :", new Reponse(1, "Un graphe", false), new Reponse(2, "Une ontologie", true), new Reponse(3, "Un réseau bayésien", false), new Reponse(4, "Aucune de ces réponses", false)));
                questions.Add(new Question(22, "La stratégie FIFO consiste à :", new Reponse(1, "Parcourir l’arbre des possibles en profondeur d’abord", false), new Reponse(2, "Parcourir l’arbre des possibles en largeur d’abord", true), new Reponse(3, "Parcourir l’arbre des possibles en longueur d’abord", false), new Reponse(4, "Ne pas parcourir l’arbre des possibles pour gagner du temps", false)));
                questions.Add(new Question(23, "Dans un problème de maths dont le but serait de trouver un nombre, on aurait en IA :", new Reponse(1, "État initial = l’énoncé, État final = le nombre recherché", true), new Reponse(2, "État initial = le nombre recherché, État final = l’énoncé", false), new Reponse(3, "État initial et final = le nombre recherché, en constante évolution", false), new Reponse(4, "On ne pourrait pas déterminer ces états", false)));

            }

            //Sauvegarde
            questions.Enregistrer(_CHEMIN);

            // lancement du form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIA());

            
        }
    }
}
