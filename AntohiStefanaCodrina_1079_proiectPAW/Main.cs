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
    public partial class Main : Form
    {
        List<Adrese> listaAdrese = new List<Adrese>();

        public Main(List<Adrese> listaAdrese)
        {
            this.listaAdrese = listaAdrese;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            VizualizareComenzi vc = new VizualizareComenzi(listaAdrese);
            vc.ShowDialog();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AdaugaComanda ac = new AdaugaComanda(listaAdrese);
            ac.ShowDialog();
        }

        
    }
}
