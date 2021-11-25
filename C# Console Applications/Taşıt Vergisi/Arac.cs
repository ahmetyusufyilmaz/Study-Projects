using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasit_Vergisi
{
    abstract class Arac
    {
        string _ID;
        short _MotorHacmi;
        byte _VitesSayisi;
        double _Fiyat;
        double _OtvFiyat;
        int _UretimYili;

        public string ID { get => _ID; set => _ID = value; }
        public short MotorHacmi { get => _MotorHacmi; set => _MotorHacmi = value; }
        public byte VitesSayisi { get => _VitesSayisi; set => _VitesSayisi = value; }
        public double Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public double OtvFiyat { get => _OtvFiyat; set => _OtvFiyat = value; }
        public int UretimYili { get => _UretimYili; set => _UretimYili = value; }

        public Arac()
        {
           
        }

        public void IndirimYap(double indirimOrani)
        {
            this.Fiyat = this.Fiyat - (this.Fiyat * indirimOrani / 100);
            Console.WriteLine($"\nYüzde {indirimOrani} indirim yapıldı.\nGüncel fiyat: {this.Fiyat} TL\n");
        }
        public void GetFiyat() { }

        abstract public void OTVHesapla();
        abstract public void YillikVergiHesapla();
    }
}
