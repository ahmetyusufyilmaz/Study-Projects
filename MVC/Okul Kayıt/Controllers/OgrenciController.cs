using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKUL.DataAccess;
using OKUL.Models;
using System.IO;
using System.Web.Security;

namespace OKUL.Controllers
{
    public class OgrenciController : Controller
    {
        private static Ogrenci _ogrenci { get; set; }
        public static Ogrenci ogrenci 
        {
            get {
                if (_ogrenci == null)
                    _ogrenci = new Ogrenci();
                return _ogrenci;
            }
            set {
                _ogrenci = value;
            }
        }
        // GET: Ogrenci
        public ActionResult Index()
        {
            List<Ogrenci> ogrenciler = OgrenciDAL.Current.ListOgrenci();
            return View(ogrenciler);
        }

        // GET: Ogrenci Create Form
        [Authorize]
        public ActionResult Create()
        {
            //Ogrenci ogrenci = new Ogrenci();
            ogrenci.ID = 0;
            ogrenci.Ad = null;
            ogrenci.Soyad = null;
            ogrenci.OgretmenID = 0;
            List<Ogretmen> ogretmenler = OgretmenDal.Current.GetTeachers();
            ViewBag.ogretmenler = ogretmenler;
            return View(ogrenci);
        }

        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {
            object insertedID = OgrenciDAL.Current.Create(ogrenci);
            ogrenci.ID = Convert.ToInt32(insertedID);

            if (Convert.ToInt32(insertedID) > 0)
            {
                // Kaydetme başarılı ise fotoğrafı yükle.
                if (ogrenci.Foto != null)
                {
                    FotoUpload(ogrenci);
                }
            }
            TempData["insertedID"] = insertedID.ToString();
            return RedirectToAction("Index");
        }

        [NonAction] // Bu metot controller acction'ı değildir.

        private void FotoUpload(Ogrenci ogrenci)
        {
            string userPath = Server.MapPath($"~/UploadedFiles/Ogrenci/{ogrenci.ID }/");
            if (!Directory.Exists(userPath))
            {
                Directory.CreateDirectory(userPath);
            }
            string fotoPath = Path.Combine(userPath, Path.GetFileName(ogrenci.Foto.FileName));
            ogrenci.Foto.SaveAs(fotoPath);
            ogrenci.FotoAdres = ogrenci.ID + "/" + ogrenci.Foto.FileName;
            OgrenciDAL.Current.Update(ogrenci);
        }

    
        
        public ActionResult Edit(int id)
        {
        ogrenci = OgrenciDAL.Current.GetByID(id);
        List<Ogretmen> ogretmenler = OgretmenDal.Current.GetTeachers();
        ViewBag.ogretmenler = ogretmenler;
        return View(ogrenci); // Veritabanından gelen öğrenciyi View'a gönderdik.
    }

        [HttpPost]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (OgrenciDAL.Current.Update(ogrenci))
            {
                if (ogrenci.Foto != null)
                    FotoUpload(ogrenci);

                return RedirectToAction("Index");
               
            }
            else
            {
                TempData["hata"] = "Öğrenci güncellenirken hata oluştu!!!!";
                return RedirectToAction("Edit", new { id = ogrenci.ID });
            }
        }

        public ActionResult Details(int id)
        {
            ogrenci = OgrenciDAL.Current.GetByID(id);
            return View(ogrenci);
        }

        public ActionResult Delete(int id)
        {
            ogrenci = OgrenciDAL.Current.GetByID(id);
            return View(ogrenci);
        }

        [HttpPost]
        public ActionResult Delete(Ogrenci ogrenci)
        {
            bool check = OgrenciDAL.Current.Delete(ogrenci);
            if (check==true)
                return RedirectToAction("Index");
            else
                TempData["hata"] = "Silmede Hata !!!";
                return RedirectToAction("Delete");

        }
        [HttpPost]
        public ActionResult Ara(string arananKelime)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler = OgrenciDAL.Current.Search(arananKelime);

            //TempData["arananKelime"] = arananKelime;
            return View(ogrenciler);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                FormsAuthentication.SetAuthCookie("admin", false);
                return RedirectToAction("Create");
            }
            return RedirectToAction("Login");
        }
    }
}