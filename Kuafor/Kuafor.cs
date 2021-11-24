using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuafor
{
    enum Hizmetler
    {
        Saç_Traşı,
        Sakal_Traşı,
        Saç_Yıkama,
        Cilt_Bakımı
    }

    class Kuafor
    {


        //Metotlar: SacTrasiYap(), SakalTrasiYap(),SacYika(),CiltBakimiYap()
        int ID;
        string Ad;
        float toplamUcret = 0;
        float sacTrasiUcreti, ciltBakimiUcreti, sakalTrasiUcreti, sacYikamaUcreti;


        List<Hizmetler> alinanHizmetler = new List<Hizmetler>();


        public Kuafor()
        {
            this.toplamUcret = 0;
            this.sacTrasiUcreti = 20.0f;
            this.sakalTrasiUcreti = 15.0f;
            this.sacYikamaUcreti = 10.0f;
            this.ciltBakimiUcreti = 30.0f;
            this.Ad = "Ahmet";
        }
        public void SacTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Traşı);
            toplamUcret += this.sacTrasiUcreti;
        }

        public void SakalTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Sakal_Traşı);
            toplamUcret += this.sakalTrasiUcreti;
        }
        public void SacYika()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Yıkama);
            toplamUcret += this.sacYikamaUcreti;
        }

        public void CiltBakimiYap()
        {
            alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            toplamUcret += this.ciltBakimiUcreti;
        }

        public void BilgiYaz()
        {
            string hizmetler = " ";
            foreach (var item in alinanHizmetler)
            {
                hizmetler += item + " ";
            }
            Console.WriteLine($"Müşteri: {this.Ad}\nYapılan işlemler:{hizmetler}\nToplam Ucret= {toplamUcret}");
        }
    }
}

