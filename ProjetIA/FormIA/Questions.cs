using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace FormIA
{
    [Serializable()]
    public class Questions : List<Question>     //On hérite d'une liste de personnes.
    {
        /// <summary>
        /// Enregistre l'état courant de la classe dans un fichier au format XML.
        /// </summary>
        /// <param name="chemin"></param>
        public void Enregistrer(string chemin)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Questions));
            StreamWriter writer = new StreamWriter(chemin);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public static Questions Charger(string chemin)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Questions));
            StreamReader reader = new StreamReader(chemin);
            Questions q = (Questions)deserializer.Deserialize(reader);
            reader.Close();

            return q;
        }
    }
}
