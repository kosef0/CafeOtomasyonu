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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan kullanıcının girdiği verileri al
            string kullaniciAdi = textBox1.Text;
            string parola = textBox2.Text;
            string adSoyad = textBox4.Text;

            // Veritabanı bağlantısını kontrol et
            Veritabani.baglantiKontrol();

            // SQL sorgusu oluştur
            string sql = $"INSERT INTO kullanicibilg (kuladi, parola, adSoyad) VALUES ('{kullaniciAdi}', '{parola}', '{adSoyad}')";

            try
            {
                // SQL sorgusunu çalıştır
                OleDbCommand cmd = new OleDbCommand(sql, Veritabani.con);
                cmd.ExecuteNonQuery();

                // Başarıyla eklendi mesajı ver
                MessageBox.Show("Kullanıcı başarıyla eklendi.");

                // TextBox'ları temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj ver
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                Veritabani.con.Close();
            }
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
