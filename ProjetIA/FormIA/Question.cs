using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormIA
{
    [Serializable]
    public class Question //une question correspond à un ensemble : intitulé + 4 réponses, dont une seule sera bonne
    {
        [XmlAttribute()]
        public int Num { get; set; }

        [XmlAttribute()]
        public string Intitule { get; set; }

        public Reponse Reponse1 { get; set; }

        public Reponse Reponse2 { get; set; }

        public Reponse Reponse3 { get; set; }

        public Reponse Reponse4 { get; set; }

        public Question()
        {

        }

        public Question(int num, string intitule, Reponse reponse1, Reponse reponse2, Reponse reponse3, Reponse reponse4)
        {
            Num = num;
            Intitule = intitule;
            Reponse1 = reponse1;
            Reponse2 = reponse2;
            Reponse3 = reponse3;
            Reponse4 = reponse4;
        }
    }
}
