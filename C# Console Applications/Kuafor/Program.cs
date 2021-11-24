using System;

namespace Kuafor
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Kuafor kuafor = new Kuafor();
            musteri.kuafor = kuafor;
            musteri.kuafor.SacTrasiYap();
            musteri.kuafor.SakalTrasiYap();
            musteri.kuafor.BilgiYaz();

        }
    }
}
