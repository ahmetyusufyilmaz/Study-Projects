using System;

namespace Tasit_Vergisi
{
    class Program
    {
        static void Main(string[] args)
        {


            Otomobil renault = new Otomobil();
            renault.ID = "Renault Megane";
            renault.UretimYili = DateTime.Now.Year;
            renault.MotorHacmi = 1600;
            renault.VitesSayisi = 6;
            renault.Fiyat = 100000.0D;
            renault.KapiSayisi = 5;
            renault.Renk = Renk.Siyah;
            Console.WriteLine($"{renault.ID}\n{renault.UretimYili} Model\n{renault.VitesSayisi} vites\nMotor Hacmi: {renault.MotorHacmi} CC\nKapı Sayısı: {renault.KapiSayisi}\n" +
                $"Renk: {renault.Renk}\n");
            OTVHesapla(renault);
            YillikVergiHesapla(renault);
            
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine();

            Ticari fiat = new Ticari();
            fiat.ID = "Fiat Ducato";
            fiat.UretimYili = DateTime.Now.Year;
            fiat.MotorHacmi = 1500;
            fiat.VitesSayisi = 5;
            fiat.Fiyat = 90000.0D;
            fiat.TasimaKapasitesi = 16;
            Console.WriteLine($"{fiat.ID}\n{fiat.UretimYili} Model\n{fiat.VitesSayisi} vites\nMotor Hacmi: {fiat.MotorHacmi} CC\nTaşıma Kapasitesi: {fiat.TasimaKapasitesi}\n");
            OTVHesapla(fiat);
            YillikVergiHesapla(fiat);

            

        }

        static void OTVHesapla(Arac arac)
        {
            arac.OTVHesapla();
        }
        static void YillikVergiHesapla(Arac arac)
        {
            arac.YillikVergiHesapla();
        }
    }
}

