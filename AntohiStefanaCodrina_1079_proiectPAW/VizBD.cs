using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    public partial class VizBD : Form
    {
        string connString;
        public List<Adrese> listaAdrese = new List<Adrese>();
        private bool modif;
        public VizBD(List<Adrese> listaAdrese)
        {
            InitializeComponent();
            this.listaAdrese = listaAdrese;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pizza.accdb";
            label1.MouseDown += new MouseEventHandler(label1_MouseDown);
            textBox1.AllowDrop = true;
            textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM tipPizza";
                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {

                    ListViewItem itm = new ListViewItem(reader["numePizza"].ToString());
                    itm.SubItems.Add(reader["TipBlat"].ToString());
                    itm.SubItems.Add(reader["extraTopping"].ToString());
                    itm.SubItems.Add(reader["sos"].ToString());
                    itm.SubItems.Add(reader["Adresa"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            AdgBd adauga = new AdgBd(listaAdrese);
            adauga.ShowDialog();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        string cod = itm.SubItems[0].Text;
                        comanda.CommandText = "DELETE FROM tipPizza WHERE numePizza = " + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexiune.Close();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.listView1.Width, this.listView1.Height);
            listView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.listView1.Width, this.listView1.Height));
            objBmp.SetResolution(93, 80);
            e.Graphics.DrawImage(objBmp, 80, 160);
            e.Graphics.DrawString("Listă comenzi pizza", new Font("Poppins", 22, FontStyle.Bold), Brushes.Indigo, new Point(250, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(label1.Text, DragDropEffects.Copy);
        }
        void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }
        void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = (string)e.Data.GetData(DataFormats.Text);
        }

       
    }
}
