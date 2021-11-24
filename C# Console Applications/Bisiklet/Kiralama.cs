using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiklet
{
    class Kiralama
    {
        private int ID;
        private int Bisiklet;
        private int Kullanici;
        private double Sure;
        private double Ucret;
        private DateTime _BaslamaZamani;
        private DateTime _BitisZamani;
        private float _SaniyeUcret;
        private Bisiklet _bisiklet;
        private Kullanici _kullanici;


        public Kiralama()
        {
            this._SaniyeUcret = 0.25f;
        }

        public DateTime BaslamaZamani
        {
            get { return this._BaslamaZamani; }
            set { this._BaslamaZamani = value; }
        }
        public DateTime BitisZamani
        {
            get { return this._BitisZamani; }
            set { this._BitisZamani = value; }
        }

        public float SaniyeUcret
        {
            get { return this._SaniyeUcret; }
            set { this._SaniyeUcret = value; }
        }

        public Bisiklet bisiklet
        {
            get { return this._bisiklet; }
            set { this._bisiklet = value; }
        }

        public Kullanici kullanici
        {
            get { return this._kullanici; }
            set { this._kullanici = value; }
        }

        public void KiralamaBaslat()
        {
            this._BaslamaZamani = DateTime.Now;
        }
        public void KiralamaBitir()
        {
            this.BitisZamani = DateTime.Now;
            this.UcretHesapla();
        }

        public double UcretHesapla()
        {
            TimeSpan fark = _BitisZamani - _BaslamaZamani;
            Ucret = fark.Seconds * _SaniyeUcret;
            return Ucret;

        }

        public void BilgiYaz()
        {
            Console.WriteLine($"Sayın {this.kullanici.AdSoyad}");
            Console.WriteLine($"Başlama zamanı: {this._BaslamaZamani}\nBitiş zamanı: {this._BitisZamani}");
            Console.WriteLine($"Ödemeniz gereken ücret = {this.Ucret} TL");

        }

    }

}

