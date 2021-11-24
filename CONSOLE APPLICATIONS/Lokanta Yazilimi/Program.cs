using System;

namespace Lokanta_Yazilimi
{
    class Program
    {
        static void Main(string[] args)
        {
            LokantaMersin lokmer = new LokantaMersin();
            LokantaTokat loktok = new LokantaTokat();
            LokantaYozgat lokyoz = new LokantaYozgat();

            BelediyeHarcOde(lokmer);
            BelediyeHarcOde(loktok);
            BelediyeHarcOde(lokyoz);
        }
        static void BelediyeHarcOde(Lokanta lkt)
        {
            lkt.BelediyeHarcOde();
        }

    }
}

/* Lokanta Yazılımı
 * BelediyeHarcOde() isminde metot var.
 * Genelde harç ücreti 6 aylık 3000 TL iken aşağıdaki illerde farklılık göstermekte.
 * LokantaTokat : 2000
 * LokantaYozgat: 1500
 * LokantaMersin: 3500
 * Bu illler için polimorfizm yapısnı kullanarak farklı metot tanımlayınız.
 * BelediyeHarcOde()
 * {
 *      Console.WriteLine("Harç Ödemesi: 3000 TL'dir.");
 * } 
 */