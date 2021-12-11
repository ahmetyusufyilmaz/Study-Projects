using System;

namespace HomePractices
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, puan = 0, toplam, dogrucevap = 0, yanliscevap = 0;
            char devamMi; //= char.Parse(Console.ReadLine());
            do
            {
                Random rnd = new Random();
                sayi1 = rnd.Next(1, 100);
                sayi2 = rnd.Next(1, 100);
                toplam = sayi1 + sayi2;
                Console.WriteLine($"{sayi1} ve {sayi2} = ?");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == toplam)
                {
                    dogrucevap++;
                    Console.WriteLine("Tebrikler! Doğru yanıtlayıp 5 puan kazandınız.");
                    puan = puan + 5;
                }
                else
                {
                    yanliscevap++;
                    Console.WriteLine("Yanlış cevap verdiniz ve -2 puan aldınız.");
                    puan = puan - 2;
                }
                Console.WriteLine("Tekrar oynamak ister misiniz?\n(Evet için e'ye hayır için h'ye basın)");
                devamMi = char.Parse(Console.ReadLine());
            }

            while (devamMi == 'e');
            {
                Console.WriteLine($"Doğru cevap sayısı: {dogrucevap}\nYanlış cevap sayısı:{yanliscevap}");
                Console.WriteLine($"Toplam puanınız: {puan}");
            }
        }
    }


}



