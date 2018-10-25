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
    public partial class FormIA : Form
    {
        public FormIA()
        {
            InitializeComponent();
        }

        private void btnQCM_Click(object sender, EventArgs e)
        {
            FormQCM qcm = new FormQCM();           
            qcm.Show();
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            FormDijkstra dijkstra = new FormDijkstra();
            dijkstra.Show();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
