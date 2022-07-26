using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;
namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Logare.accdb");
        OleDbCommand comanda = new OleDbCommand();
        OleDbDataAdapter adapt = new OleDbDataAdapter();

        private void btnLogare_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string parola = textBox2.Text;

            try
            {
                conexiune.Open();

                string login = "SELECT * FROM Users WHERE username = '" + username + "' AND Password = '" + parola + "'";
                comanda = new OleDbCommand(login, conexiune);
                OleDbDataReader dr = comanda.ExecuteReader();

                if (dr.Read() == true)
                {
                    MessageBox.Show("Conexiune cu succes!");
                    this.Hide();
                    Form2 dash = new Form2();
                    dash.Closed += (s, args) => this.Close();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Numele utilizatorului si parola sunt gresite! ");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {

                conexiune.Close();
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        
    }
}
