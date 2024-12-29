using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand("select *from kullanicibilg where kuladi=@kuladi and parola=@parola", baglanti);
            giris.Parameters.Add("kuladi", textBox1.Text);
            giris.Parameters.Add("parola", textBox2.Text);
            OleDbDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                icerik form = new icerik();
                form.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Girdiğiniz Bilgiler Yanlış. Lütfen Tekrar deneyiniz..");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
