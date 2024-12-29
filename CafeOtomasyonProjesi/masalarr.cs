using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonProjesi
{
    public partial class masalarr : Form
    {
        public masalarr()
        {
            InitializeComponent();
        }
        public static int MasaNumarasi;
        public static int masaSayisi;
        public static Boolean ayaraGit;
        int doluMasaSayisi = 0;
        public static masalarr anaFrm;

        public void lstMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMasa.SelectedItems.Count > 0)
            {
                int masaNo = Convert.ToInt32(lstMasa.SelectedItems[0].Text.Substring(0, lstMasa.SelectedItems[0].Text.IndexOf('.')));

            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MasaNumarasi = (int.Parse(lstMasa.SelectedIndices[0].ToString()) + 1);


                SiparisForm frmMasa = new SiparisForm();
                frmMasa.ShowDialog();
            }
            catch
            {

            }

        }

        private void lstMasa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstMasa.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                     //contextMenuStrip1.Show(Cursor.Position);
                }
            }

        }
        //private void masayiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (lstMasa.SelectedItems.Count > 0 && lstMasa.SelectedItems[0].ImageKey == "dolumasa.png")
        //    {
        //        int masaNo = Convert.ToInt32(lstMasa.SelectedItems[0].Text.Substring(0, lstMasa.SelectedItems[0].Text.IndexOf('.')));
        //        int siparisNo = Siparis.siparisNoGetir(masaNo);
        //        if (MessageBox.Show("Eğer masayı kapatırsanız hesap ödenmeden masa içerisindeki ürünler kaldırılacaktır." +
        //            "\n(*Raporlarda kapatılan masaların bilgilerini göremezsiniz.)" +
        //            "\nDevam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //        {
        //            if (Siparis.siparisUrunTemizle(siparisNo))
        //            {

        //                if (Siparis.siparisTemizle(siparisNo))
        //                {
        //                    lstMasa.SelectedItems[0].ImageKey = "bosmasa.png";
        //                    frmAna.anaFrm.lstMasa_SelectedIndexChanged(null, null);
        //                }
        //            }
        //        }
        //    }
        //}

        private void frmAna_Load(object sender, EventArgs e)
        {
            anaFrm = this;

            DataTable dt = Veritabani.VeriGetir("select * from Ayar");

            DataTable masa = Veritabani.VeriGetir("select MasaSayisi from Ayar");
            //for (int i = 0; i < int.Parse(masa.Rows[0]["MasaSayisi"].ToString()); i++)
            //{

            //    if (kontroller.veriVarmi("select * from Siparis where MasaNo=" + (i + 1) + " AND Hesap=True"))
            //    {
            //        lstMasa.Items.Add((i + 1) + ".Masa");
            //        lstMasa.Items[i].ImageKey = "dolumasa.png";
            //        doluMasaSayisi++;
            //    }
            //    else
            //    {
            //        lstMasa.Items.Add((i + 1) + ".Masa");
            //        lstMasa.Items[i].ImageKey = "bosmasa.png";
            //    }

            //}
            //masaSayisi = Convert.ToInt32(masa.Rows[0]["MasaSayisi"].ToString());


            //    frmGiris frmg = new frmGiris();
            //   frmg.ShowDialog();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(120, 120);
            imageList.Images.Add("bosMasa", Properties.Resources.bosmasa); // Boş masa resmi ekleniyor
            imageList.Images.Add("doluMasa", Properties.Resources.dolumasa); // Dolu masa resmi ekleniyor

            // ListView'ın SmallImageList özelliğine ImageList'i atayarak küçük simgeleri gösteriyoruz
            lstMasa.SmallImageList = imageList;

            // View özelliğini SmallIcon olarak ayarlıyoruz
            lstMasa.View = View.SmallIcon;

            for (int i = 0; i < int.Parse(masa.Rows[0]["MasaSayisi"].ToString()); i++)
            {
                ListViewItem item = new ListViewItem((i + 1) + ".Masa");

                if (kontroller.veriVarmi("select * from Siparis where MasaNo=" + (i + 1) + " AND Hesap=True"))
                {
                    item.ImageKey = "doluMasa"; // Dolu masa resmi atanıyor
                    doluMasaSayisi++;
                }
                else
                {
                    item.ImageKey = "bosMasa"; // Boş masa resmi atanıyor
                }

                lstMasa.Items.Add(item);
            }

        }
        private void frmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            this.Close();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            personel frm = new personel();
            this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            icerik form = new icerik();
            this.Close();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            masalarr form = new masalarr();
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
                
            this.Close();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rezervasyon form = new rezervasyon();
                this.Close();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa kasa = new kasa();
            this.Close();
            kasa.Show();
        }
    }
}
