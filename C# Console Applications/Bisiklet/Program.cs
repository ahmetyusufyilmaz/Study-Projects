using System;
using System.Threading.Tasks;
using System.Threading;

namespace Bisiklet
{
    /*
             * BİSİKLET KİRALAMA YAZILIMI
             * Bisiklet: ID,Marka,Model,JantBoyutu,VitesSayisi 
             * Kullanici: ID,AdSoyad,Telefon 
             * Kiralama: ID,BisikletID,KullaniciID,Sure,Ucret,BaslamaZamani,BitisZamani,DakikaUcret
             * Metotlar: 
             * KiralamaBaslat()=> BaşlamaZamanini tut. 
             * KiralamaBitir()=> BitisZamanini tut. 
             * UcretHesapla()=> Bitiş ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek.(double)
             * BilgiYaz() => Şu zamanda başladın bu zamanda bitirdiniz. 
             * Toplam ... saniye kullandınız. Ödemen gereken ücret ... liradır.
             * */
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici ahmet = new Kullanici();
            ahmet.AdSoyad = "Ahmet Yusuf Yılmaz";

            Bisiklet bisan = new Bisiklet();
            bisan.Marka = "Bisan";

            Kiralama kiralama = new Kiralama();
            kiralama.kullanici = ahmet;
            kiralama.bisiklet = bisan;
            kiralama.KiralamaBaslat();
            Thread.Sleep(10000); // 10 saniye bekle
            kiralama.KiralamaBitir();
            kiralama.BilgiYaz();
        }
    }
}
