using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonProjesi
{
    class SiparisGetir
    {
        public static bool siparisEkle(object masaNo)//Siparis tablosuna siparisleri ekliyor
        {
            Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into Siparis (MasaNo,Hesap) values (@masano,True)", Veritabani.con);
                cmd.Parameters.Add("@masano", OleDbType.Integer).Value = masaNo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }


        }
        //veritabanıma ekleme yapması için
        public static bool siparisUrunEkle(object siparisNo, object urunNo, object urunAdet)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into SiparisUrun (SiparisNo,UrunNo,UrunAdet) values (@siparisNo,@urunNo,@urunAdet)", Veritabani.con);
                cmd.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                cmd.Parameters.Add("@urunNo", OleDbType.Integer).Value = urunNo;
                cmd.Parameters.Add("@urunAdet", OleDbType.Integer).Value = urunAdet;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool siparisUrunTemizle(object siparisNo)
        {
            Veritabani.baglantiKontrol();
            try
            {

                OleDbCommand sil = new OleDbCommand("delete from SiparisUrun where SiparisNo=@siparisNo", Veritabani.con);
                sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                sil.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }//SiparisUrun tablosunda siparisNo ile silme işlemi yapar


        public static bool siparisTemizle(object siparisNo)
        {
            Veritabani.baglantiKontrol();
            try
            {

                OleDbCommand sil = new OleDbCommand("delete from Siparis where SiparisNo=@siparisNo", Veritabani.con);
                sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                sil.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }//Siparis tablosunda siparisNo ile silme işlemi yapar
        public static int siparisNoGetir(object masaNo)
        {
            DataTable dt = Veritabani.VeriGetir("select SiparisNo from Siparis where MasaNo=" + masaNo + " AND Hesap=True");
            if (dt.Rows.Count > 0)
            {
                int siparisNo = Convert.ToInt32(dt.Rows[0][0].ToString());//yeni açılan masanın siparis numarasını aldık
                return siparisNo;
            }
            else
            {
                return -1;
            }
        }//Masanumarası ile siparis numarasını bulur ve geri gönderir
    }
}
