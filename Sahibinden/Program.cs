using System;

namespace Sahibinden
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici1 = new Kullanici();
            kullanici1.AdSoyad = "Şakir Demir";
            kullanici1.Telefon = "05342321210";

            Kullanici kullanici2 = new Kullanici();
            kullanici2.AdSoyad = "Ali Yılmaz";
            kullanici2.Telefon = "05372921280";


            Ilan ilan = new Ilan();
            ilan.IlanN = 129823;
            ilan.Baslik = "Yıl Sonu İndirimleri";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Satici = kullanici1;
            ilan.Fiyat = 10000;
            
           

            Masaustu mst = new Masaustu();

            mst.Satici = kullanici2;
            mst.Kategori = Kategori.Masaüstü_Bilgisayar;
            mst.IlanN = 13122;
            mst.IlanTarihi = DateTime.Now;
            mst.Baslik = "Sağlam Masaüstü Bilgisayar";
            mst.Islemci = "AMD Ryzen 7";
            mst.Fiyat = 10000.0D;
            mst.Marka = "MSI";
            mst.Bellek = "32GB";
            mst.HDD = 512;
            mst.SSD = 512;
            mst.EthernetVarMi = true;
            mst.WifiVarMi = false;
            mst.MonitorVarMi = false;
            mst.KasaTipi = KasaTipi.Dikey;
          
            mst.BilgiYaz();
            Console.WriteLine($"\nFiyat: {mst.Fiyat} TL" );
            ilan.IndirimYap(10);
            Console.WriteLine("------------------------------------------\n");

            Ilan ilan2 = new Ilan();
            ilan2.IlanN = 154123;
        
            ilan2.IlanTarihi = DateTime.Now;
            ilan2.Satici = kullanici1;
            ilan2.Fiyat = 8000;

            Dizustu dzb = new Dizustu();
            dzb.Satici = kullanici1;
            dzb.Kategori = Kategori.Dizüstü_Bilgisayar;
            dzb.IlanN = 54351;
            dzb.IlanTarihi = DateTime.Now;
            dzb.Baslik = "Sıfır ayarında Disüstü Bilgisayar";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 5";
            dzb.Fiyat = 8000.0D;
            dzb.Marka = "Lenovo";
            dzb.Bellek = "16GB";
            dzb.HDD = 0;
            dzb.SSD = 512;
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.EkranBoyutu = "14'";

            dzb.BilgiYaz();
            Console.WriteLine($"Fiyat: {dzb.Fiyat} TL");
            ilan2.IndirimYap(15);
        }
    }
}
