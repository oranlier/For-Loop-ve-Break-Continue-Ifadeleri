using System;

namespace For_Loop_ve_Break_Continue_Ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("bir sayı giriniz:");
            int sayac = int.Parse( Console.ReadLine() );
            for (int i = 0; i <= sayac; i++)
            {
                if (i%2==1)
                    Console.WriteLine(i);
            }
            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdırmak
            int tektoplam=0;
            int cifttoplam =0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                    tektoplam +=i;//tektoplam=tektoplam+i
                else
                    cifttoplam +=i;
            }
            Console.WriteLine("tek toplam = " + tektoplam);
            Console.WriteLine("cift toplam = " + cifttoplam);

            //break, continue
            //dongu ıcerısınde bır sarta baglı olarak donguden cıkmak için kullanılır.
            //bir sarta baglı olarak mevcut dongunun o adımını atlamak için kullanılır.

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
            Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
            Console.WriteLine(i);
            }
        }
    }
}
