using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonProjesi
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        int masaNo;
        ImageList imageList1 = new ImageList();

        private void urunGoster()
        {
            DataTable urun = Veritabani.VeriGetir("select * from Urun where SilinmisMi=False");
            DataTable grup = Veritabani.VeriGetir("select * from UrunGrubu");
            for (int groupIndex = 0; groupIndex < grup.Rows.Count; ++groupIndex)
            {
                //grubları listviewe ekliyor
                this.lstUrunler.Groups.Add(grup.Rows[groupIndex]["UrunGrupNo"].ToString(), grup.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < urun.Rows.Count; ++urunIndex)
                {
                    if (urun.Rows[urunIndex]["UrunGrupNo"].ToString() == grup.Rows[groupIndex]["UrunGrupNo"].ToString())
                    {


                        if (File.Exists(urun.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                        {
                            Image myImage = Image.FromFile(urun.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                            imageList1.Images.Add(urun.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                            ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString() + "-" + urun.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                urun.Rows[urunIndex]["UrunNo"].ToString(), this.lstUrunler.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.lstUrunler.Items.Insert(0, item);//ürünü ekliyor
                        }
                        else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                        {
                            ListViewItem item = new ListViewItem(urun.Rows[urunIndex]["Adi"].ToString() + "-" + urun.Rows[urunIndex]["Fiyati"].ToString() + " ₺", urun.Rows[urunIndex]["UrunNo"].ToString(),
                            this.lstUrunler.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.lstUrunler.Items.Insert(0, item);//ürünü ekliyor
                            //this.lstUrunler.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }

                    }

                }
            }
        }



        private void sepetUrunGoster()
        {
            try
            {
                int siparisNo = SiparisGetir.siparisNoGetir(masaNo);
                if (kontroller.veriVarmi("select * from SiparisUrun where SiparisNo=" + siparisNo + ""))
                {
                    DataTable siparisUrun = Veritabani.VeriGetir("select Urun.UrunNo as UrunNo,SiparisUrun.UrunAdet as UrunAdet,Urun.Adi as Adi,Urun.Fiyati as Fiyati,Urun.ResimYolu as ResimYolu from SiparisUrun inner join Urun on SiparisUrun.UrunNo=Urun.UrunNo where SiparisUrun.SiparisNo=" + siparisNo + "");
                    for (int urunIndex = 0; urunIndex < siparisUrun.Rows.Count; ++urunIndex)
                    {
                        for (int i = 0; i < Convert.ToInt32(siparisUrun.Rows[urunIndex]["UrunAdet"].ToString()); i++)
                        {
                            if (File.Exists(siparisUrun.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                            {
                                Image myImage = Image.FromFile(siparisUrun.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                                imageList1.Images.Add(siparisUrun.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                                ListViewItem item = new ListViewItem(siparisUrun.Rows[urunIndex]["Adi"].ToString() + "-" + siparisUrun.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                    siparisUrun.Rows[urunIndex]["UrunNo"].ToString(), this.lstUrunler.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.lstSepet.Items.Insert(0, item);//ürünü ekliyor
                                this.lstSepet.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();

                            }
                            else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                            {
                                ListViewItem item = new ListViewItem(siparisUrun.Rows[urunIndex]["Adi"].ToString() + "-" + siparisUrun.Rows[urunIndex]["Fiyati"].ToString() + " ₺", siparisUrun.Rows[urunIndex]["UrunNo"].ToString(),
                                this.lstSepet.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.lstSepet.Items.Insert(0, item);//ürünü ekliyor
                                this.lstSepet.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();
                            }
                        }


                    }

                }
            }
            catch
            {
                MessageBox.Show("SepetUrunGoster Metodunda hata");
            }


        }

        private void comboDoldur()
        {
            DataTable dt = Veritabani.VeriGetir("select * from OdemeTuru");
            comboOdemeTuru.DataSource = dt;
            comboOdemeTuru.DisplayMember = "Adi";
            comboOdemeTuru.ValueMember = "OdemeTuruNo";
        }
        private void siparisleriKaydet()
        {
            if (lstSepet.Items.Count > 0)
            {
                if (kontroller.veriVarmi("select * from Siparis where MasaNo=" + masaNo + " AND Hesap=True"))
                {
                    int siparisNo = SiparisGetir.siparisNoGetir(masaNo);
                    if (SiparisGetir.siparisUrunTemizle(siparisNo))
                    {
                        foreach (ListViewItem item in lstSepet.Items)
                        {
                            if (item.Group == lstSepet.Groups[0])
                            {
                                if (!kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                //Ürün bir defa eklendiyse bir daha eklemiyor bunun kontrolü
                                {

                                    int urunAdeti = 0;
                                    for (int i = 0; i < lstSepet.Groups[0].Items.Count; i++)
                                    {
                                        if (item.ImageKey == lstSepet.Groups[0].Items[i].ImageKey)
                                        {
                                            urunAdeti++;
                                            //eklenen ürün birden fazla ise sayısını buluyoruz
                                        }
                                    }
                                    if (SiparisGetir.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti))
                                    {
                                        //Ürünü ekliyor
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ürünler eklenirken hata!");
                                    }
                                }

                            }
                            else
                            {

                            }

                        }


                    }
                }
                else
                {
                    if (SiparisGetir.siparisEkle(masaNo))
                    {
                        int siparisNo = SiparisGetir.siparisNoGetir(masaNo);
                        foreach (ListViewItem item in lstSepet.Items)
                        {
                            if (item.Group == lstSepet.Groups[0])
                            {
                                if (!kontroller.veriVarmi("select UrunNo from SiparisUrun where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                //Ürün bir defa eklendiyse bir daha eklemiyor bunun kontrolü
                                {

                                    int urunAdeti = 0;
                                    for (int i = 0; i < lstSepet.Groups[0].Items.Count; i++)
                                    {
                                        if (item.ImageKey == lstSepet.Groups[0].Items[i].ImageKey)
                                        {
                                            urunAdeti++;
                                            //eklenen ürün birden fazla ise sayısını buluyoruz
                                        }
                                    }
                                    if (SiparisGetir.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti))
                                    {
                                        //Ürünü ekliyor
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ürünler eklenirken hata!");
                                    }
                                }

                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Siparisler eklenirken hata meydana geldi.");
                    }

                }
            }
        }

        private void frmMasa_Load(object sender, EventArgs e)
        {


            this.Text = "Masa " + masalarr.MasaNumarasi.ToString();
            masaNo = Convert.ToInt32(this.Text.Substring(Convert.ToInt32(this.Text.IndexOf(' '))));
            grpUrun.Visible = true;
            urunGoster();
            comboDoldur();

            //grubları listviewe ekliyor
            this.lstSepet.Groups.Add("0", "Ürünler");
            int siparisNo = SiparisGetir.siparisNoGetir(masaNo);
            if (siparisNo != -1)
            {
                sepetUrunGoster();
            }

        }
        private void lstUrunler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }




        private void lstSepet_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem seciliItem in lstSepet.SelectedItems)
            {
                double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                txtToplam.Text = (Convert.ToDouble(txtToplam.Text) - fiyati).ToString();
                lstSepet.Items[seciliItem.Index].Remove();
            }

        }

        

        int siparisNo;
        private void btnHesapOde_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count > 0)
            {
                if (MessageBox.Show("Hesabı Ödemek İstiyor Musunuz?", "Hesap Öde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ProgresBarım progressBarForm = new ProgresBarım();
                    progressBarForm.Show();



                    siparisleriKaydet();
                    siparisNo = SiparisGetir.siparisNoGetir(masaNo);
                    if (HesapGetir.hesapOde(siparisNo, comboOdemeTuru.SelectedValue, txtToplam.Text))
                    {
                        if (comboOdemeTuru.SelectedIndex == 0)//peşin
                        {
                            //Kasa.ParaEkle(txtToplam.Text, 0);
                        }



                    }
                    if (masalarr.anaFrm.lstMasa.Items[masaNo - 1].ImageKey == "dolumasa")
                    {
                        masalarr.anaFrm.lstMasa.Items[masaNo - 1].ImageKey = "bosmasa";
                        

                        
                    }
                    
                    lstSepet.Items.Clear();


                    

                }
            }

        }

        private void txtVerilenMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtVerilenMiktar.Text != "")
            {
                txtParaUstu.Text = (Convert.ToDouble(txtVerilenMiktar.Text) - Convert.ToDouble(txtToplam.Text)).ToString();
            }
            else
            {
                txtParaUstu.Text = "0";
            }
        }

        private void txtVerilenMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtVerilenMiktar.Text.IndexOf(',') != -1)
            {
                if (e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            kontroller.txtParaKontrol(e);
        }



        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            
            if (lstUrunler.SelectedItems.Count > 0)
            {
                foreach (ListViewItem seciliItem in lstUrunler.SelectedItems)
                {
                    double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                    txtToplam.Text = (Convert.ToDouble(txtToplam.Text) + fiyati).ToString();

                    ListViewItem item = new ListViewItem(lstUrunler.Items[seciliItem.Index].Text, lstUrunler.Items[seciliItem.Index].ImageKey, this.lstSepet.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz

                    this.lstSepet.Items.Insert(0, item);//ürünü ekliyor
                                                        //this.lstSepet.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor

                    lstUrunler.SelectedItems[0].Selected = false;
                }
            }
        }

        private void txtToplam_TextChanged(object sender, EventArgs e)
        {
            txtVerilenMiktar_TextChanged(null, null);
        }

        private void comboOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            this.Text = "Masa " + masalarr.MasaNumarasi.ToString();
            masaNo = Convert.ToInt32(this.Text.Substring(Convert.ToInt32(this.Text.IndexOf(' '))));
            grpUrun.Visible = true;
            urunGoster();
            comboDoldur();

            //grubları listviewe ekliyor
            this.lstSepet.Groups.Add("0", "Ürünler");
            int siparisNo = SiparisGetir.siparisNoGetir(masaNo);
            if (siparisNo != -1)
            {
                sepetUrunGoster();
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstSepet.Items.Count > 0)
            {
                siparisleriKaydet();
                if (masalarr.anaFrm.lstMasa.Items[masaNo - 1].ImageKey == "bosmasa.png")
                {
                    masalarr.anaFrm.lstMasa.Items[masaNo - 1].ImageKey = "dolumasa.png";//Masayı dolu gösteriyoruz

                }

            }
            masalarr.anaFrm.lstMasa_SelectedIndexChanged(null, null);
        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if textBox1 is not empty
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    // Parse the value from textBox1
                    double percentage = double.Parse(textBox1.Text);

                    // Calculate the new value for textBox2
                    double result = Convert.ToDouble(txtToplam.Text) - (Convert.ToDouble(txtToplam.Text) * (percentage / 100));

                    // Assign the result to textBox2
                    textBox2.Text = result.ToString();
                }
                else
                {
                    // If textBox1 is empty, set textBox2 to txtToplam
                    textBox2.Text = txtToplam.Text;
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that might occur during parsing or calculation
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtParaUstu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Hem txtVerilenMiktar hem de textBox2'nin boş olup olmadığını kontrol ediyoruz
                if (!string.IsNullOrEmpty(txtVerilenMiktar.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    // 
                    double verilenMiktar = double.Parse(txtVerilenMiktar.Text);
                    double totalAmount = double.Parse(textBox2.Text);

                    // Hesaplıyoruz
                    double paraUstu = verilenMiktar - totalAmount;

                    // Assign the result to txtParaUstu
                    txtParaUstu.Text = paraUstu.ToString();
                }
                else
                {
                    
                    txtParaUstu.Text = "";
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("HATA: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
