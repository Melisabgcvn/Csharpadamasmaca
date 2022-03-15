using AppKit;
using System;


namespace adamasmaca
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);

            string[] kelimeler = { "güven", "huzur", "mutluluk", "eğlence", "gençlik " };
            int sayac = 0;
            int bitis = 0;
            Random rand = new Random();
            string oyun_kelimesi = kelimeler[rand.Next(0, kelimeler.Length - 1)];
            int can = oyun_kelimesi.Length;
            char[] yer_tutucu = new char[oyun_kelimesi.Length];

            //bilgi ver

            char harf;
            
            Console.WriteLine("kelimeniz " + oyun_kelimesi.Length + " harflidir.");
            for (int i = 0; i < oyun_kelimesi.Length; i++)
            {
                Console.Write("_ ");
            }
            
            Console.WriteLine();

            //tahmine başla
            
            for (int j = 0; bitis <= oyun_kelimesi.Length - 1; j++)
            {
                
                Console.WriteLine("harf tahmini yapınız:");
                harf = Convert.ToChar(Console.ReadLine());

                
                for (int i = 0; i < oyun_kelimesi.Length; i++)
                {

                    if (harf == oyun_kelimesi[i])
                    {
                        sayac += 1;
                        bitis += 1;
                        Console.WriteLine("bu harf kelimenizde " + (i + 1) + ".yerde var");
                    }
                }
                if (sayac == 0)
                {
                    can -= 1;
                    Console.WriteLine("canınız:" + can);

                }
                sayac = 0;
                if (can == 0)
                {
                    Console.WriteLine("Canınız bitti.");
                    Console.WriteLine(oyun_kelimesi);
                }
                if (bitis == oyun_kelimesi.Length)
                {
                    Console.WriteLine("tahmininiz var mı?(e/h)");
                    char tahminvarmi = Convert.ToChar(Console.ReadLine());
                    if (tahminvarmi == 'e' || tahminvarmi == 'E')
                    {
                        Console.WriteLine("Tahmininizi Giriniz:");
                        string tahmin = Convert.ToString(Console.ReadLine());
                        if (tahmin == oyun_kelimesi)
                        {
                            Console.WriteLine("Doğru Kelime.Tebrikler.");

                        }
                        else
                        {
                            Console.WriteLine("Yanlış kelime.");
                            Console.WriteLine("Kelimeniz: " + oyun_kelimesi);
                        }
                    }
                    else
                    {
                        Console.WriteLine("kelimeniz" + oyun_kelimesi);

                    }
                    Console.WriteLine("Oyun bitti.");
                }
            }
            Console.ReadLine();

        }

    }

}

