using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortgen dikdortgen = new Dortgen();
           // dikdortgen.AlanHesapla();
            //dikdortgen.CevreHesapla();
            

            Daire daire = new Daire();
            //daire.AlanHesapla();
            //daire.CevreHesapla();

            Ucgen dikucgen = new Ucgen();
            //dikucgen.AlanHesapla();
            //dikucgen.CevreHesapla();

            Alan(dikucgen);
            Cevre(dikucgen);
            Alan(daire);
            Cevre(daire);
            Alan(dikdortgen);
            Cevre(dikdortgen);




        }
        static void Alan(Sekil sekil)
        {
            sekil.AlanHesapla();
        }
        static void Cevre(Sekil sekil)
        {
            sekil.CevreHesapla();
        }
    }
}
