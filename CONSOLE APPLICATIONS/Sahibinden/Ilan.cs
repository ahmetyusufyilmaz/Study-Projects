using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahibinden
{
    enum Kategori
    {
        Masaüstü_Bilgisayar,
        Dizüstü_Bilgisayar,
        Temizlik_Ürünü
    }
    class Ilan
    {

        private long _IlanN;
        public long IlanN
        {
            get { return this._IlanN; }
            set
            {
                try
                {
                    this._IlanN = value;
                }
                catch
                {
                    Console.WriteLine("Atama yapılamadı !!!");
                }
            }
        }

        public string Baslik { get => _Baslik; set => _Baslik = value; }
        public DateTime IlanTarihi { get => _IlanTarihi; set => _IlanTarihi = value; }
        internal Kategori Kategori { get => _Kategori; set => _Kategori = value; }
        public double Fiyat { get => _Fiyat; set => _Fiyat = value; }
        internal Kullanici Satici { get => _Satici; set => _Satici = value; }

        private string _Baslik;

        private DateTime _IlanTarihi;

        private Kategori _Kategori;

        private double _Fiyat;

        private Kullanici _Satici;

        public void BilgiYaz()
        {
            
            Console.WriteLine("******* İLAN BİLGİLERİ *******");
            Console.WriteLine($"İlan Numarası : {this.IlanN} ");
            Console.WriteLine($"Başlık : {this.Baslik} ");
            Console.WriteLine($"İlan Tarihi : {this.IlanTarihi} ");
            Console.WriteLine($"Kategori : {this.Kategori} ");          
            Console.WriteLine();
            Console.WriteLine("***** SATICI BİLGİLERİ *****");
            Console.WriteLine($"Satıcı : {this.Satici.AdSoyad} ");
            Console.WriteLine($"Satıcı Telefonu : {this.Satici.Telefon} ");
            Console.WriteLine();
            Console.WriteLine("******** ÜRÜN BİLGİLERİ *******\n");
        }
        public void IndirimYap(double indirimYuzdesi)
        {
            this.Fiyat = this.Fiyat - (this.Fiyat * indirimYuzdesi / 100);
            Console.WriteLine($"\nYüzde {indirimYuzdesi} indirim yapıldı.\nGüncel fiyat: {this.Fiyat} TL\n");
        }
    }
}