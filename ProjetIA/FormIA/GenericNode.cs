using System.Collections.Generic;
using System;

namespace FormIA
{
    // classe abstraite, il est donc impératif de créer une classe qui en hérite
    // pour résoudre un problème particulier en y ajoutant des infos liées au contexte du problème
    abstract public class GenericNode
    {
        protected double GCost;               //coût du chemin du noeud initial jusqu'à ce noeud
        protected double HCost;               //estimation heuristique du coût pour atteindre le noeud final
        protected double TotalCost;           //coût total (g+h)
        protected GenericNode ParentNode;     // noeud parent
        protected List<GenericNode> Enfants;  // noeuds enfants

        public GenericNode() //noeud générique de base
        {
            ParentNode = null;
            Enfants = new List<GenericNode>();
        }


        public double GetGCost() //reourne la valeur du chemin du noeud initial jusqu'à un noeud
        {
            return GCost;
        }

        public void SetGCost(double g) //déinfi une valeur g de chemin du noeud initial jusqu'à un noeud
        {
            GCost = g;
        }

        //méthodes get set pour les noeuds parents et enfants
        public double Cout_Total
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }

        public List<GenericNode> GetEnfants()
        {
            return Enfants;
        }

        public GenericNode GetNoeud_Parent()
        {
            return ParentNode;
        }

        public void SetNoeud_Parent(GenericNode g)
        {
            ParentNode = g;
            g.Enfants.Add(this);
        }


        public void Supprime_Liens_Parent() //supprime les liens entre parents et enfants
        {
            if (ParentNode == null) return;
            ParentNode.Enfants.Remove(this);
            ParentNode = null;
        }

        public void calculCoutTotal() //calule le coût total d'un chemin d'un point à un autre
        {
            HCost = CalculeHCost();
            TotalCost = GCost + HCost;
        }

        public void RecalculeCoutTotal() //permet de comparer les coût totaux de plusieurs chemins
        {
            TotalCost = GCost + HCost;
        }

        public string ToLetter()
        {
            return ((char)(Convert.ToInt32(this.ToString()) + 65)).ToString();
        }

        // Méthodes abstraites, donc à surcharger obligatoirement avec override dans une classe fille
        public abstract bool IsEqual(GenericNode N2);
        public abstract double GetArcCost(GenericNode N2);
        public abstract bool EndState();
        public abstract List<GenericNode> GetListSucc();
        public abstract double CalculeHCost();
    }
}
