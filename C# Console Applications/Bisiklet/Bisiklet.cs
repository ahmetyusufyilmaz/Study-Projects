using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiklet
{
        class Bisiklet
        {
            private int ID;
            private string _Marka;
            private string _Model;
            private float _JantBoyutu;
            private byte _VitesSayisi;


            public string Marka
            {
                get { return this._Marka; }
                set { this._Marka = value; }
            }

            public string Model
            {
                get { return this._Model; }
                set { this._Model = value; }
            }

            public float JantBoyutu
            {
                get { return this._JantBoyutu; }
                set { this._JantBoyutu = value; }
            }

            public byte VitesSayisi
            {
                get { return this._VitesSayisi; }
                set { this._VitesSayisi = value; }
            }
        }
    }

