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
    public partial class kasa : Form
    {
        public kasa()
        {
            InitializeComponent();
        }
        private string connectionString = "Provider=microsoft.jet.oledb.4.0; data source = |DataDirectory|\\ODEV.mdb";

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

        private void label4_Click(object sender, EventArgs e)
        {
            DisplayTotalAmount();

        }
        private void DisplayTotalAmount()
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
                            label4.Text = Convert.ToDouble(result).ToString("C2"); // Display as currency
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DisplayDailyEarnings()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Get today's date in the format 'dd.MM.yyyy'
                    string todayDate = DateTime.Now.ToString("dd.MM.yyyy");

                    string query = "SELECT SUM(Tutar) FROM Hesap WHERE Format(Tarih, 'dd.MM.yyyy') = @TodayDate";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Use OleDbParameter to avoid SQL injection and handle date formats
                        command.Parameters.AddWithValue("@TodayDate", todayDate);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label5.Text = Convert.ToDouble(result).ToString("C2"); // Display as currency
                        }
                        else
                        {
                            label5.Text = "0"; // If there are no records
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DisplayMonthlyEarnings()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Get the current month and year
                    string currentMonthYear = DateTime.Now.ToString("MM/yyyy");

                    string query = "SELECT SUM(Tutar) FROM Hesap WHERE Format(Tarih, 'MM/yyyy') = @CurrentMonthYear";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Use OleDbParameter to avoid SQL injection and handle date formats
                        command.Parameters.AddWithValue("@CurrentMonthYear", currentMonthYear);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            label6.Text = Convert.ToDouble(result).ToString("C2"); // Display as currency
                        }
                        else
                        {
                            label6.Text = "0"; // If there are no records
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void kasa_Load(object sender, EventArgs e)
        {
            DisplayTotalAmount();
            DisplayDailyEarnings();
            DisplayMonthlyEarnings();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
