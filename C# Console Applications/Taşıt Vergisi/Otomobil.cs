using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasit_Vergisi
{
    enum Renk
    {
        Kırmızı,
        Siyah,
        Beyaz,
        Gri,
        Füme
    }
    class Otomobil : Arac
    {
        byte _KapiSayisi;
        Renk _Renk;

        public byte KapiSayisi { get => _KapiSayisi; set => _KapiSayisi = value; }
        internal Renk Renk { get => _Renk; set => _Renk = value; }
        public Otomobil()
        {

        }


        public override void OTVHesapla()
        {


            if (this.MotorHacmi >= 0 && this.MotorHacmi <= 999)
                Console.WriteLine($"Otomobil Fiyatı: {this.Fiyat} TL\nÖTV: {(this.Fiyat * 0.05)} TL");

            else if (this.MotorHacmi >= 1000 && this.MotorHacmi <= 1599)
                Console.WriteLine($"Otomobil Fiyatı: {this.Fiyat} TL\nÖTV: {(this.Fiyat * 0.1)} TL");

            else if (this.MotorHacmi >= 1600 && this.MotorHacmi <= 1999)
                Console.WriteLine($"Otomobil Fiyatı: {this.Fiyat} TL\nÖTV: {(this.Fiyat * 0.15)} TL");

            else
                Console.WriteLine($"Otomobil Fiyatı: {this.Fiyat} TL\nÖTV: {(this.Fiyat * 0.2)} TL");
        }

        public override void YillikVergiHesapla()
        {
            if (this.UretimYili >= 2017 && this.UretimYili <= 2021) // 0-4 Yaş arası
            {
                if (this.MotorHacmi >= 0 && this.MotorHacmi <= 999) // 0-4 Yaş arası ve 0-999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.02) + (this.Fiyat * 0.05)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.05) + (this.Fiyat * 0.02)) / 2) + (this.Fiyat * 0.05)+(this.Fiyat)  } TL");
                    this.Fiyat = (((this.Fiyat * 0.05) + (this.Fiyat * 0.02)) / 2) + (this.Fiyat * 0.05) + (this.Fiyat);
                }
                else if (this.MotorHacmi >= 1000 && this.MotorHacmi <= 1599) // 0-4 Yaş arası ve 1000-1599 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {((this.Fiyat * 0.05) + (this.Fiyat * 0.05)) / 2} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: { (((this.Fiyat * 0.05) + (this.Fiyat * 0.05)) / 2) + (this.Fiyat * 0.10)+(this.Fiyat) } TL");
                    this.Fiyat = (((this.Fiyat * 0.05) + (this.Fiyat * 0.05)) / 2) + (this.Fiyat * 0.10) + (this.Fiyat);
                }
                else if (this.MotorHacmi >= 1600 && this.MotorHacmi <= 1999)// 0-4 Yaş arası ve 1600-1999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {((this.Fiyat * 0.08) + (this.Fiyat * 0.05))/2} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.08) + (this.Fiyat * 0.05)) / 2) + (this.Fiyat * 0.15)+(this.Fiyat)} TL");  
                    this.Fiyat = (((this.Fiyat * 0.08) + (this.Fiyat * 0.05)) / 2) + (this.Fiyat * 0.15) + (this.Fiyat);
                }
                else if (this.MotorHacmi >= 2000)// 0-4 Yaş arası ve +2000 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.1) + (this.Fiyat * 0.05)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.05) + (this.Fiyat * 0.1))) / 2 + (this.Fiyat * 0.2)+(this.Fiyat) } TL");
                    this.Fiyat = (((this.Fiyat * 0.05) + (this.Fiyat * 0.1))) / 2 + (this.Fiyat * 0.2) + (this.Fiyat);
                }
            }

            else if (this.UretimYili >= 2012 && this.UretimYili <= 2016) // 5-9 yaş arası
            {
                if (this.MotorHacmi >= 0 && this.MotorHacmi <= 999) // 5-9 yaş arası ve 0-999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.02) + (this.Fiyat * 0.04)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.02) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.05)} TL");
                    this.Fiyat = (((this.Fiyat * 0.02) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.05);
                }
                else if (this.MotorHacmi >= 1000 && this.MotorHacmi <= 1599) // 5-9 yaş arası ve 1000-1599 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.05) + (this.Fiyat * 0.04)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: { (((this.Fiyat * 0.05) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.1)} TL");
                    this.Fiyat = (((this.Fiyat * 0.05) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.1);
                }
                else if (this.MotorHacmi >= 1600 && this.MotorHacmi <= 1999)// 5-9 yaş arası ve 1600-1999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.08) + (this.Fiyat * 0.04)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.08) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.15)} TL");
                    this.Fiyat = (((this.Fiyat * 0.08) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.15);
                }
                else if (this.MotorHacmi >= 2000) // 5-9 yaş arası ve +2000 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.1) + (this.Fiyat * 0.04)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.1) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.2)} TL");
                    this.Fiyat = (((this.Fiyat * 0.1) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.2);
                }
            }

            else if (this.UretimYili <= 2011) // 10+ yaş
            {
                if (this.MotorHacmi >= 0 && this.MotorHacmi <= 999) // 10+ yaş  ve 0-999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.02) + (this.Fiyat * 0.03)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.02) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.05)} TL");
                    this.Fiyat = (((this.Fiyat * 0.02) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.05);
                }
                else if (this.MotorHacmi >= 1000 && this.MotorHacmi <= 1599) // 10+ yaş ve 1000-1599 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.05) + (this.Fiyat * 0.03)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.05) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.1)} TL");
                    this.Fiyat = (((this.Fiyat * 0.05) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.1);
                }
                else if (this.MotorHacmi >= 1600 && this.MotorHacmi <= 1999)// 10+ yaş ve 1600-1999 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {(this.Fiyat * 0.08) + (this.Fiyat * 0.03)} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.08) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.15)} TL");
                    this.Fiyat = (((this.Fiyat * 0.08) + (this.Fiyat * 0.03))) / 2 + (this.Fiyat) + (this.Fiyat * 0.15);
            }

                else if (this.MotorHacmi >= 2000) // 5-9 yaş arası ve +2000 CC
                {
                    Console.WriteLine($"Yıllık Vergi: {((this.Fiyat * 0.1) + (this.Fiyat * 0.03)) / 2} TL");
                    Console.WriteLine($"ÖTV + Yıllık vergi dahil ücret: {(((this.Fiyat * 0.1) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.2)} TL");
                    this.Fiyat = (((this.Fiyat * 0.1) + (this.Fiyat * 0.04))) / 2 + (this.Fiyat) + (this.Fiyat * 0.2);
                }
            }
        }



    }


}
