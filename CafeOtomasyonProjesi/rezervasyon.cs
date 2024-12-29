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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeOtomasyonProjesi
{
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listele()

        {
            

            DataTable tablo = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Rezerv", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;



        }
        private void rezervasyon_Load(object sender, EventArgs e)
        {
            Veritabani.baglantiKontrol(); // Bağlantıyı kontrol et

            // Veritabanından Rezerv tablosunu çek ve DataGridView'e yükle
            string sorgu = "SELECT * FROM Rezerv";
            dataGridView1.DataSource = Veritabani.VeriGetir(sorgu);
            listele();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki sırasına göre ilgili hücreleri TextBox'lara yerleştirme
                textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox2.Text = selectedRow.Cells["AdiSoyadi"].Value.ToString();
                textBox3.Text = selectedRow.Cells["KisiSayisi"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Telefon"].Value.ToString();
                textBox6.Text = selectedRow.Cells["MasaNo"].Value.ToString();

                // Tarih hücresinin değerini al ve DateTimePicker'a atama
                if (selectedRow.Cells["Tarih"].Value != null)
                {
                    DateTime tarih;
                    if (DateTime.TryParse(selectedRow.Cells["Tarih"].Value.ToString(), out tarih))
                    {
                        dateTimePickerTarih.Value = tarih;
                    }
                    else
                    {
                        // Hata durumu, varsayılan bir tarih atayabilirsiniz
                        dateTimePickerTarih.Value = DateTime.Now;
                    }
                }
                else
                {
                    // Tarih değeri null ise, varsayılan bir tarih atayabilirsiniz
                    dateTimePickerTarih.Value = DateTime.Now;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();

                // Kullanıcının girdiği bilgileri al
                int id = Convert.ToInt32(textBox1.Text);
                string adiSoyadi = textBox2.Text;
                int kisiSayisi = Convert.ToInt32(textBox3.Text);
                DateTime tarih = dateTimePickerTarih.Value;
                string telefon = textBox5.Text;
                int masaNo = Convert.ToInt32(textBox6.Text);

                
                string sorgu = "INSERT INTO Rezerv (ID, AdiSoyadi, KisiSayisi, Tarih, Telefon, MasaNo) VALUES (@id, @adiSoyadi, @kisiSayisi, @tarih, @telefon, @masaNo)";
                OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@adiSoyadi", adiSoyadi);
                cmd.Parameters.AddWithValue("@kisiSayisi", kisiSayisi);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@masaNo", masaNo);

                
                cmd.ExecuteNonQuery();

                // DataGridView'i güncelle
                string selectQuery = "SELECT * FROM Rezerv";
                dataGridView1.DataSource = Veritabani.VeriGetir(selectQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri ekleme hatası: " + ex.Message);
            }
            finally
            {
                
                baglanti.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Rezerv set AdiSoyadi=@p1,KisiSayisi=@p2,Tarih=@p3,Telefon=@p4,MasaNo=@p5 where ID=@p8", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", dateTimePickerTarih);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.Parameters.AddWithValue("@p8", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            label15.Text = " Kullanıcı başarıyla güncellendi. :D";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("DELETE FROM Rezerv WHERE ID = @p1", baglanti);
                sil.Parameters.AddWithValue("@p1", textBox1.Text); // Kullanıcının girdiği ID'ye göre sil
                sil.Parameters.AddWithValue("@p1", textBox2.Text);
                sil.Parameters.AddWithValue("@p2", textBox3.Text);
                sil.Parameters.AddWithValue("@p3", dateTimePickerTarih);
                sil.Parameters.AddWithValue("@p4", textBox5.Text);
                sil.Parameters.AddWithValue("@p6", textBox6.Text);
                sil.Parameters.AddWithValue("@p8", textBox1.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();

                label15.Text = "Kullanıcı başarıyla silindi. :(";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
