using System;

namespace Enumm
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Salı);

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava Soğuk Dışarı çıkarken Kalın giyin");
            }
            else if (sıcaklık >= (int)HavaDurumu.Soğuk && sıcaklık <= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Hava dışarıya çıkmak için çok uygun");
            }
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşmebe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 10,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}