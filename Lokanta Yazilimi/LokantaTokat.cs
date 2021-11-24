using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta_Yazilimi
{
    class LokantaTokat:Lokanta
    {
        public LokantaTokat()
        {
            base._HarcUcreti = 2000;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Tokat Belediyesi Harç Ücreti: {this._HarcUcreti}");
        }


    }
}
