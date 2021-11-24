using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Daire : Sekil
    {
        int _Yaricap;
        double _Pi;


        public Daire()
        {
            this._Yaricap = 4;
            this._Pi = 3.14D;
        }


        public override void AlanHesapla()
        {
            Console.WriteLine($"Dairenin Yarıçapı: {this._Yaricap}\nDairenin alanı: {this._Yaricap * this._Yaricap * this._Pi}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Dairenin çevresi: {(this._Pi * this._Yaricap) * 2}\n");
        }
    }
}
