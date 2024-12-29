using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonProjesi
{
    class kontroller
    {
        public static void txtSayiKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            // text'e sadece sayıların girmesi,geri silme tuşu(ascii kodu:08),virgül(ascii kodu:44) karakterinin girilmesini sağlar.
            //del tuşununda aktif olmasını isterseniz del ascıı kodu:127
            //
            {
                e.Handled = true;

            }
        }

        public static void txtParaKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            // text'e sadece sayıların girmesi,geri silme tuşu(ascii kodu:08),virgül(ascii kodu:44) karakterinin girilmesini sağlıyor.
            //del tuşununda aktif olmasını isterseniz del ascıı kodu:127
            //
            {
                e.Handled = true;
            }

        }
        public static bool veriVarmi(string sql)
        {
            Veritabani.baglantiKontrol();
            OleDbCommand cmd = new OleDbCommand(sql, Veritabani.con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kullaniciKontrolu(string kulAdi, string sifre)//kullanici adi ve parola kontrolü.
        {

            Veritabani.baglantiKontrol();
            OleDbCommand cmd = new OleDbCommand("select kullanicinum from kullanicibilg where kuladi=@kuladi and parola=@sifre", Veritabani.con);
            cmd.Parameters.Add("@kuladi", OleDbType.VarWChar).Value = kulAdi;
            cmd.Parameters.Add("@sifre", OleDbType.VarWChar).Value = sifre;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
