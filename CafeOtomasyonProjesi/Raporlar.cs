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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
            TotalCiro();
            TotalPersonel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {


            // En çok ve en az tekrarlanan UrunNo'yu al ve Urun tablosundan Adi'ni getir
            string sqlMax = "SELECT TOP 1 UrunNo FROM SiparisUrun GROUP BY UrunNo ORDER BY COUNT(UrunNo) DESC";
            DataTable urunNoTableMax = Veritabani.VeriGetir(sqlMax);

            string sqlMin = "SELECT TOP 1 UrunNo FROM SiparisUrun GROUP BY UrunNo ORDER BY COUNT(UrunNo) ASC";
            DataTable urunNoTableMin = Veritabani.VeriGetir(sqlMin);

            if (urunNoTableMax.Rows.Count > 0)
            {
                int urunNoMax = Convert.ToInt32(urunNoTableMax.Rows[0]["UrunNo"]);

                // Urun tablosundan Adi'ni al
                string urunAdiSqlMax = $"SELECT Adi FROM Urun WHERE UrunNo = {urunNoMax}";
                DataTable urunAdiTableMax = Veritabani.VeriGetir(urunAdiSqlMax);

                if (urunAdiTableMax.Rows.Count > 0)
                {
                    string urunAdiMax = urunAdiTableMax.Rows[0]["Adi"].ToString();
                    label3.Text = urunAdiMax;
                }
                else
                {
                    MessageBox.Show("Urun tablosunda belirtilen UrunNo'ya ait kayıt bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("SiparisUrun tablosunda hiç kayıt bulunamadı.");
            }

            if (urunNoTableMin.Rows.Count > 0)
            {
                int urunNoMin = Convert.ToInt32(urunNoTableMin.Rows[0]["UrunNo"]);

                // Urun tablosundan Adi'ni al
                string urunAdiSqlMin = $"SELECT Adi FROM Urun WHERE UrunNo = {urunNoMin}";
                DataTable urunAdiTableMin = Veritabani.VeriGetir(urunAdiSqlMin);

                if (urunAdiTableMin.Rows.Count > 0)
                {
                    string urunAdiMin = urunAdiTableMin.Rows[0]["Adi"].ToString();
                    label5.Text = urunAdiMin;
                }
                else
                {
                    MessageBox.Show("Urun tablosunda belirtilen UrunNo'ya ait kayıt bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("SiparisUrun tablosunda hiç kayıt bulunamadı.");
            }

            // Display total records in SiparisUrunNo column
            string totalSiparisUrunNoSql = "SELECT COUNT(SiparisUrunNo) FROM SiparisUrun";
            int totalSiparisUrunNoCount = Convert.ToInt32(Veritabani.VeriGetir(totalSiparisUrunNoSql).Rows[0][0]);
            label9.Text = $"{totalSiparisUrunNoCount}";

        }
        private string connectionString = "Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb";

        private void DisplayTotalAmount()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM SiparisUrun";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label9.Text = result.ToString(); // Display the total row count
                        }
                        else
                        {
                            label4.Text = "0"; // If there are no records
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void TotalCiro()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(Tutar) FROM Hesap";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label13.Text = Convert.ToDouble(result).ToString("C2"); // Display as currency
                        }
                        else
                        {
                            label13.Text = "0"; // If there are no records
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {
            TotalCiro();
        }
        private void TotalPersonel()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM personelbilg";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label12.Text = result.ToString(); 
                        }
                        else
                        {
                            label12.Text = "0"; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
