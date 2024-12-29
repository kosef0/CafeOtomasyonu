using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonProjesi
{
    class HesapGetir
    {
        public static bool hesapOde(object siparisNo, object odemeTuru, object tutar)
        {
            Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand Siparis = new OleDbCommand("update Siparis set Hesap=False where SiparisNo=" + siparisNo + " ", Veritabani.con);
                Siparis.ExecuteNonQuery();
                OleDbCommand Hesap = new OleDbCommand("insert into Hesap (SiparisNo,OdemeTuruNo,Tutar) values (@siparisNo,@odemeTuruNo,@tutar)", Veritabani.con);
                Hesap.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                Hesap.Parameters.Add("@odemeTuruNo", OleDbType.TinyInt).Value = odemeTuru;
                Hesap.Parameters.Add("@tutar", OleDbType.Currency).Value = tutar;
                Hesap.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
