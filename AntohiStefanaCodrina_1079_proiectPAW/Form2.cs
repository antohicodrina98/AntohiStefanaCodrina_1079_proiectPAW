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
    public partial class Form2 : Form
    {
        List<Adrese> listaAdrese = new List<Adrese>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main vc = new Main();
            vc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main2 mc = new Main2();
            mc.ShowDialog();
        }
    }
}
