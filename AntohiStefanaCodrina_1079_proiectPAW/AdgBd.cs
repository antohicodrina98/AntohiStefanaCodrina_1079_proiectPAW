using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class AdgBd : Form
    {
        private string numePizza = "", blat, extraTopping, sos, adresa, connString;
        List<Adrese> listaAdrese = new List<Adrese>();
        Adrese adrese;
  
        public AdgBd()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pizza.accdb";
        }

       

        public AdgBd(List<Adrese> listaAdrese)
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pizza.accdb";
            this.listaAdrese = listaAdrese;
           
        }

        public AdgBd(string numePizza, string blat, string extraTopping, string sos, string adresa)
        {
            InitializeComponent();
            this.numePizza = numePizza;
            this.blat = blat;
            this.extraTopping = extraTopping;
            this.sos = sos;
            this.adresa = adresa;
        }

        

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pizza.accdb");
            if (cbNumePizza.Text == "")
                errorProvider1.SetError(cbNumePizza, "Adaugati pizza!");

            else
            if (cbBlat.Text == "")
                errorProvider1.SetError(cbBlat, "Adaugati bratul!");

            else
            if (cbExtraTopping.Text.Length > 10)
                errorProvider1.SetError(cbExtraTopping, "Adauga extra topping");

            else
            if (cbSos.Text == "")
                errorProvider1.SetError(cbSos, "Adauga sos");
            else
            if (tbAdresa.Text == "")
                errorProvider1.SetError(tbAdresa, "Adauga adresa");
            else
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;

                    comanda.CommandText = "INSERT INTO tipPizza VALUES(?,?,?,?,?)";
                    comanda.Parameters.Add("numePizza", OleDbType.Char).Value = cbNumePizza.Text;
                    comanda.Parameters.Add("TipBlat", OleDbType.Char).Value = cbBlat.Text;
                    comanda.Parameters.Add("extraTopping", OleDbType.Char).Value = cbExtraTopping.Text;
                    comanda.Parameters.Add("sos", OleDbType.Char).Value = cbSos.Text;
                    comanda.Parameters.Add("Adresa", OleDbType.Char).Value = tbAdresa.Text;
                    

                    comanda.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                    cbNumePizza.Items.Clear();
                    cbBlat.Items.Clear();
                    cbExtraTopping.Items.Clear();
                    cbSos.Items.Clear();
                    tbAdresa.Clear();
                    MessageBox.Show("Am adaugat activitatea");
                }
           
        }
        private void AdaugarePizza_Load(object sender, EventArgs e)
        {

            cbNumePizza.Text = numePizza;
            if (String.IsNullOrEmpty(numePizza))
                cbNumePizza.Enabled = true;
            else
                cbNumePizza.Enabled = false;
            cbBlat.Text = Convert.ToString(blat);
            cbExtraTopping.Text = extraTopping;
            cbSos.Text = sos;
            tbAdresa.Text = adresa;
            if (String.IsNullOrEmpty(adresa))
                tbAdresa.Enabled = true;
            else
                tbAdresa.Enabled = false;
            if (String.IsNullOrEmpty(numePizza))
            {
                btnAdauga.Visible = true;
               
            }
            else
            {
                btnAdauga.Visible = false;
               
            }


        }

        private void AdaugareFirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdauga.PerformClick();
            
        }

    }
}
