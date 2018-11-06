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
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        
        [STAThread]
        public static void Main()
        {            
            // lancement du form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIA());

            
        }
    }
}
