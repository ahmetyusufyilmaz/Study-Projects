using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Dortgen:Sekil
    {
        int _En, _Boy;

        public Dortgen()
        {
            this._Boy = 5;
            this._En = 3;
        }

        public override void AlanHesapla()
        {
            Console.WriteLine($"Dörtgenin Eni: {this._En}\nDörtgenin Boyu: {this._Boy}\nDörtgenin Alanı: {this._Boy*this._En}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Dörtgenin çevresi: {(this._Boy+this._En)*2}\n");
        }
    }
}
