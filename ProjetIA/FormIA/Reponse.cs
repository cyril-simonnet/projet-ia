using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace FormIA
{
    [Serializable]
    public class Reponse //une réponse possède un intitulé, un numéro et une valeur (vraie ou fausse)
    {
        [XmlAttribute()]
        public int Num { get; set; }

        [XmlAttribute()]
        public string Intitule { get; set; }

        [XmlAttribute()]
        public bool Value { get; set; }

        public Reponse()
        {
        }

        public Reponse(int num, string intitule, bool value)
        {
            Num = num;
            Intitule = intitule;
            Value = value;
        }
    }
}
