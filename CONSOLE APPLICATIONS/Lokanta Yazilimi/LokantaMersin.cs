using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta_Yazilimi
{
    class LokantaMersin : Lokanta
    {
        public LokantaMersin()
        {
            base._HarcUcreti = 3500;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Mersin Belediyesi Harç Ücreti: {this._HarcUcreti}");
        }

    }
}
