using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeOtomasyonProjesi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            FillComboBox();
            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");

        private void button3_Click(object sender, EventArgs e)
        {
            icerik frm = new icerik();
            this.Close();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            this.Close();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            masalarr frm = new masalarr();
            this.Close();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rezervasyon frm = new rezervasyon();
            this.Close();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            personel frm = new personel();
            this.Close();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa frm = new kasa();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            this.Close();
            frm.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }
        private void listele()

        {
            OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");

            DataTable tablo = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Menubilg", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;



        }
        


        
        private void FillComboBox()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");
            string query = "SELECT DISTINCT Kategoriad FROM Menubilg"; // Sadece benzersiz Kategoriad'leri almak için DISTINCT kullanıyoruz.

            using (OleDbCommand cmd = new OleDbCommand(query, baglanti))
            {
                baglanti.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Kategoriad"].ToString());
                }

                baglanti.Close();
            }
        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");
            OleDbCommand komut = new OleDbCommand("Select * From Menubilg where Kategoriad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Menubilg (ID,Urunad,Kategoriad,Fiyat,Picture) values (@ID,@Urunad,@Kategoriad,@Fiyat,@Picture)", baglanti);
            komut.Parameters.AddWithValue("@ID", textBox7.Text);
            komut.Parameters.AddWithValue("@Urunad", textBox1.Text);
            komut.Parameters.AddWithValue("@Kategoriad", textBox2.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox3.Text);
            komut.Parameters.AddWithValue("Picture", pictureBox3.ImageLocation);
            


            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Menubilg set Urunad=@p1,Kategoriad=@p2,Fiyat=@p3,Picture=@p4 where ID=@p8", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", pictureBox3.ImageLocation);
            komut.Parameters.AddWithValue("@p8", textBox7.Text);

            
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            listele();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox7.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Urunad"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Kategoriad"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Fiyat"].Value.ToString();

                // Pictureden resim yükledim

                string imagePath = selectedRow.Cells["Picture"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pictureBox3.ImageLocation = imagePath;  // Set pictureBox3 to null
                    pictureBox1.ImageLocation = imagePath;
                }
                else
                {
                    pictureBox3.Image = null;
                    pictureBox1.Image = null;
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("Delete From Menubilg where Urunad=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", textBox1.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            listele();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
