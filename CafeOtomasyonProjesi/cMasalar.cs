using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CafeOtomasyonProjesi
{
    internal class cMasalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durumu;
        private int _Onay;
        #endregion // Fields

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int Kapasite { get { return _Kapasite; } set { _Kapasite = value; } }

        public int ServisTuru { get { return _ServisTuru; } set { _ServisTuru = value; } }

        public int Durumu { get { return _Durumu; } set { _Durumu = value; } }

        public int Onay { get { return _Onay; } set { _Onay = value; } }
        #endregion // Properties

        AnaClass gnl = new AnaClass();
        public string SessionSum(int state)
        {
            string dt = "";
            OleDbConnection con = new OleDbConnection(gnl.conString);
            OleDbCommand cmd = new OleDbCommand("Select TARIH, MASAID From Adisyon Right Join Masabilg on Adisyon.MASAID=Masabilg.ID where Masabilg.Durumu=@durum and Adisyon.Durum=0", con);

            OleDbDataReader dr = null;
            cmd.Parameters.Add("@durum", OleDbType.Integer).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
    }
}

