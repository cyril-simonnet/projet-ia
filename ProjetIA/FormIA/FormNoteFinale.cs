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
    public partial class FormNoteFinale : Form
    {
        public FormNoteFinale()
        {
            InitializeComponent();
            lblScore.Text = "3"; //doit être le score filnal du formQCM, comment le récupérer.. ?
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
