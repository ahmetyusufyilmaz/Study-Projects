using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahibinden
{
    enum KasaTipi
    {
        Dikey,
        Yatay,
        ThinClient
    }
    class Masaustu : Bilgisayar
    {
        //Masaustu:Bilgisayar=> : MonitorVarMi,KasaTipi
        //: BilgiYaz metodu yeniden tanımlanacak.

        private bool _MonitorVarMi;
        private KasaTipi _KasaTipi;

        public bool MonitorVarMi { get => _MonitorVarMi; set => _MonitorVarMi = value; }
        internal KasaTipi KasaTipi { get => _KasaTipi; set => _KasaTipi = value; }


        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine($"Marka : {base.Marka}");
            Console.WriteLine($"İşlemci : {base.Islemci}");
            Console.WriteLine($"Bellek : {base.Bellek}");
            Console.WriteLine($"HDD : {base.HDD}");
            Console.WriteLine($"SSD : {base.SSD}");
            string monitor = "Yok";
            if (this.MonitorVarMi)
                monitor = "Var";
            Console.WriteLine($"Monitor : {monitor}");
            Console.WriteLine($"Kasa Tipi : {this.KasaTipi}");
        }
    }
}
