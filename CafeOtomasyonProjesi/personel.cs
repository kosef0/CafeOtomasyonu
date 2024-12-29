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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki sırasına göre ilgili hücreleri TextBox'lara yerleştirme
                textBox7.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox1.Text = selectedRow.Cells["ADI"].Value.ToString();
                textBox2.Text = selectedRow.Cells["SOYADI"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Cinsiyet"].Value.ToString();
                textBox4.Text = selectedRow.Cells["pozisyon"].Value.ToString();
                textBox5.Text = selectedRow.Cells["TELEFON"].Value.ToString();
                textBox6.Text = selectedRow.Cells["Adres"].Value.ToString();
                listele();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Geçerli bir hücreye tıklandığını kontrol et
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ADI") // "ADI" sütununa tıklandığını kontrol et
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // İlgili satırdaki "Resim" sütunundaki veriyi al
                    string imagePath = selectedRow.Cells["Resim"].Value.ToString();

                    // Resim yolunu PictureBox'a yükleme
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        pictureBox2.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        // Resim bulunamazsa PictureBox'ı temizleme veya varsayılan bir resim yükleme
                        pictureBox2.Image = null; // veya varsayılan bir resim yükleyin: pictureBox2.Image = Properties.Resources.VarsayilanResim;
                    }
                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Select * From personelbilg where ADI=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox8.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox8.Clear();
        }
        private void listele()

        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from personelbilg", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into personelbilg (ID,ADI,SOYADI,Cinsiyet,pozisyon,TELEFON,Adres,Resim) values (@ID,@ADI,@SOYADI,@Cinsiyet,@pozisyon,@TELEFON,@Adres,@Resim)", baglanti);
            komut.Parameters.AddWithValue("@ID", textBox7.Text);
            komut.Parameters.AddWithValue("@ADI", textBox1.Text);
            komut.Parameters.AddWithValue("@SOYAD", textBox2.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            komut.Parameters.AddWithValue("@pozisyon", textBox4.Text);
            komut.Parameters.AddWithValue("@TELEFON", textBox5.Text);
            komut.Parameters.AddWithValue("@Adres", textBox6.Text);
            komut.Parameters.AddWithValue("Resim", pictureBox3.ImageLocation);

            komut.ExecuteNonQuery();
            baglanti.Close();
            label15.Text = textBox1.Text + " adlı kullanıcı başarıyla eklendi. :)";
            label15.Text = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox3.Image = null;


            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update personelbilg set ADI=@p1,SOYADI=@p2,Cinsiyet=@p3,pozisyon=@p4,TELEFON=@p5,Adres=@p6,Resim=@p7 where ID=@p8", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.Parameters.AddWithValue("@p7", pictureBox3.ImageLocation);
            komut.Parameters.AddWithValue("@p8", textBox7.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            label15.Text = " Kullanıcı başarıyla güncellendi. :D";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand("Delete From personelbilg where ADI=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", textBox1.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            label15.Text = " Kullanıcı başarıyla silindi. :(";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            listele();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void personel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }
    }
}
