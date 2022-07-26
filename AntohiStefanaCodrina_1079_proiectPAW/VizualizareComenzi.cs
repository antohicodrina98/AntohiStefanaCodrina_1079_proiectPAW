using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class VizualizareComenzi : Form
    {
        List<Adrese> listaAdrese = new List<Adrese>();
        public VizualizareComenzi(List<Adrese>listaAd)
        {
            InitializeComponent();
            this.listaAdrese = listaAd;
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            foreach (Adrese a in this.listaAdrese)
            {
                string[] row = { a.NumePizza,  a.Blat.ToString(), a.ExtraTopping.ToString(),a.Sos.ToString(), a.Adresa.ToString() };
                ListViewItem lv = new ListViewItem(row);
                lv.Tag = a;
                listView1.Items.Add(lv);
                this.listView1.View = View.Details;
            }

        }
        public static void Serialize(object value, string path)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AdaugaComanda ac = new AdaugaComanda(listaAdrese);
            ac.ShowDialog();
        }

       
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                {
                    listaAdrese.Remove((Adrese)itm.Tag);
                    itm.Remove();
                }
            }

            Serialize(listaAdrese, "comenzi.bin");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
