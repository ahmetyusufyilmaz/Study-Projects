using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokanta_Yazilimi
{
    class LokantaYozgat:Lokanta
    {
        public LokantaYozgat()
        {
            base._HarcUcreti = 1500;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Yozgat Belediyesi Harç Ücreti: {this._HarcUcreti}");
        }


    }
}
