using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta_Yazilimi
{
    abstract class Lokanta
    {
       
            protected double _HarcUcreti;

            public Lokanta()
            {
                this._HarcUcreti = 0;
            }

        abstract public void BelediyeHarcOde();
        
        }
    }


