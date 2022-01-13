using OKUL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OKUL.DataAccess
{
    public class OgretmenDal
    {
        private static OgretmenDal _Current { get; set; }
        public static OgretmenDal Current
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new OgretmenDal();
                }
                return _Current;
            }
        }
        public object Create(Ogretmen ogretmen)
        {
            string query = $"Insert into tb_ogretmen (Ad,Soyad,Alan) VALUES  ('{ogretmen.Ad}','{ogretmen.Soyad}','{ogretmen.Alan}');select CAST(scope_identity() as int);";
            object insertedsId = DbTools.Connection.Create(query);
            return insertedsId;
        }
        public List<Ogretmen> GetTeachers()
        {
            string query = "select * from tb_ogretmen";

            return DbTools.Connection.ReadOgretmen(query);
        }
        public Ogretmen GetTeacherById(int id)
        {
            string query = $"select * from tb_ogretmen where ID ={id};";
            return DbTools.Connection.ReadOgretmen(query)[0];// ogrenci listesinin ilk elemannı döndürür
        }
        public bool Update(Ogretmen ogretmen)
        {
            string query = $"Update tb_ogretmen set Ad='{ogretmen.Ad}',Soyad='{ogretmen.Soyad}', Alan='{ogretmen.Alan}' where Id='{ogretmen.ID}';";
            return DbTools.Connection.Execute(query);
        }
        public bool Delete(Ogretmen ogretmen)
        {
            string query = $"Delete from tb_ogretmen where Id ={ogretmen.ID};";
            return DbTools.Connection.Execute(query);
        }

    }
}