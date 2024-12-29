using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeOtomasyonProjesi
{
    public partial class icerik : Form
    {
        public icerik()
        {
            InitializeComponent();
        }
        

        private void icerik_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel form = new personel();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            this.Close();
            frm.Show();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle frm = new KullaniciEkle();
            this.Close();
            frm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            masalarr frm = new masalarr();
            this.Close();
            frm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            menu frm = new menu();
            this.Close();
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            kasa frm = new kasa();
            this.Close();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            this.Close();
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            personel frm = new personel();
            this.Close();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rezervasyon frm = new rezervasyon();
            this.Close();
            frm.Show();
        }
    }
}
