using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;


namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class AdaugaComanda : Form
    {
        Adrese adresa;
        public List<Adrese> listaAdrese = new List<Adrese>();
        public AdaugaComanda(List<Adrese> listaAdr)
        {
            InitializeComponent();
            this.listaAdrese = listaAdr;
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numePizza = Convert.ToString(cbNumePizza.Text);
            string blat = cbBlat.Text;
            string extraTopping = Convert.ToString(cbExtraTopping.Text);
            string sos = Convert.ToString(cbSos.Text);
            string adresa = tbAdresa.Text;
            listaAdrese.Add(new Adrese(numePizza, blat, extraTopping, sos, adresa));

            Serialize(listaAdrese, "comenzi.bin");
            MessageBox.Show("Activitate adaugata cu succes!");
            MessageBox.Show("Am adaugat activitatea");

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

        public static object Deserialize(string path)
        {
            if (!System.IO.File.Exists(path)) { throw new NotImplementedException(); }

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(path))
            {
                return formatter.Deserialize(fStream);
            }
        }

        private void cbSos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbExtraTopping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNumePizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Blat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
