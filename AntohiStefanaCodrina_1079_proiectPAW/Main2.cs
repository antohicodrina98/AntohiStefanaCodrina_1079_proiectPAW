using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class Main2 : Form
    {
        List<Adrese> listaAdrese=new List<Adrese>();
   
        public Main2()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AdgBd ac = new AdgBd(listaAdrese);
            ac.ShowDialog();
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            VizBD vz = new VizBD(listaAdrese);
            vz.ShowDialog();
        }
    }
}
