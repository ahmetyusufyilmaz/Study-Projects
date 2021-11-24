using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Ucgen : Sekil
    {
        int _Yukseklik;
        int _Taban;
        int _Kenar1;
        int _Kenar2;
        public Ucgen()
        {
            this._Yukseklik = 4;
            this._Taban = 6;
            this._Kenar1 = 3;
            this._Kenar2 = 4;
        }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Üçgenin Tabanı: {this._Taban}\nÜçgenin Yüksekliği: {this._Yukseklik}\nÜçgenin Alanı: {(this._Taban * this._Yukseklik) / 2}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Üçgenin 1.Kenarı: {this._Kenar1}\nÜçgenin 2.Kenarı: {this._Kenar2}\nÜçgenin çevresi: {(this._Taban + this._Kenar1+this._Kenar2)}\n");
        }




    }
}