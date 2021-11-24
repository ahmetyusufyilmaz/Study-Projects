using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuafor
{
    class Musteri
    {


        private int ID { get; set; }
        private string _AdSoyad;
        private string _Telefon;


        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }

        }


        public string Telefon
        {
            get { return this._Telefon; }
            set { this._Telefon = value; }


        }
        public Kuafor kuafor;
    }
}


