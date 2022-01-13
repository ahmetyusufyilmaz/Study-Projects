using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OKUL.DataAccess;
using OKUL.Models;

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
        public ActionResult Create()
        {
            //Ogrenci ogrenci = new Ogrenci();
            ogrenci.ID = 0;
            ogrenci.Ad = null;
            ogrenci.Soyad = null;
            return View(ogrenci);
        }

        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {
            object insertedID = OgrenciDAL.Current.Create(ogrenci);

            TempData["insertedID"] = insertedID.ToString();


            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            //Ogrenci ogrenci = OgrenciDAL.Current.GetByID(id);
            return View(ogrenci); // Veritabanından gelen öğrenciyi View'a gönderdik.
        }

        [HttpPost]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (OgrenciDAL.Current.Update(ogrenci))
                return RedirectToAction("Index");
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
    }
}