using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using OKUL.Models;
using OKUL.DataAccess;

namespace OKUL.DataAccess
{
    public class DbTools
    {
        static string strConnection = ConfigurationManager.ConnectionStrings["db_okul"].ConnectionString;
        SqlConnection con = new SqlConnection(strConnection);
        private static DbTools _Con { get; set; }
        public static DbTools Connection
        {
            get
            {
                if (_Con == null)
                    _Con = new DbTools();
                return _Con;
            }
        }
        public bool ConnectDB()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DisconnectDB()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object Create(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            object insertedID = -1;
            try
            {
                ConnectDB();
                insertedID = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                Console.WriteLine("HATA LOGU Yaz.");
            }
            finally
            {
                DisconnectDB();
            }
            return insertedID;

        }

        public List<Ogrenci> ReadOgrenci(string query)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            SqlCommand cmd = new SqlCommand(query, con);
            IDataReader reader;
            try
            {
                ConnectDB();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ogrenciler.Add(
                        new Ogrenci()
                        {
                            ID = int.Parse(reader["ID"].ToString()),
                            Ad = reader["Ad"].ToString(),
                            Soyad = reader["Soyad"].ToString(),
                            Sinif = reader["Sinif"].ToString(),
                            OgretmenID = int.Parse(reader["OgretmenID"].ToString()),
                            FotoAdres = reader["FotoAdres"].ToString()
                        }
                        ); 
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DisconnectDB();
            }
            return ogrenciler;
        }

        public List<Ogretmen> ReadOgretmen(string query)
        {
            List<Ogretmen> ogretmenler = new List<Ogretmen>();
            SqlCommand cmd = new SqlCommand(query, con);
            IDataReader reader;
            try
            {
                ConnectDB();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ogretmenler.Add(
                        new Ogretmen
                        {
                            ID = int.Parse(reader["ID"].ToString()),
                            Ad = reader["Ad"].ToString(),
                            Soyad = reader["Soyad"].ToString(),
                            Alan = reader["Alan"].ToString()
                        });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               DisconnectDB();

            }
            return ogretmenler;
        }

        public bool Execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            int affectedRows = -1;
            try
            {
                ConnectDB();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DisconnectDB();
            }
            if (affectedRows > 0)
                return true;
            else
                return false;
        }
    }
}