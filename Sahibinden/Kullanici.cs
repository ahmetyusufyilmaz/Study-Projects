using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahibinden
{
    class Kullanici
    {
        private int _ID;
        public int ID { get { return this._ID; } }

        private string _AdSoyad;
        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._AdSoyad = value;
                }
            }
        }

        private string _Telefon;
        public string Telefon
        {
            get { return this._Telefon; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this._Telefon = value;
                }
            }
        }
    }
}

