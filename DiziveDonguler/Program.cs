using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziveDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] Renkler = new string[5];
            string[] Hayvanlar = {"Kuş","Ayı","Kaplumbağa","Deve","Aslan"};

            int[] Dizi;
            Dizi=new int[3];

            //Dizilere değer Atama ve Erişim
            Renkler[0] = "Mavi";
            Dizi[2] = 10;
            Console.WriteLine(Hayvanlar[2]);
            Console.WriteLine(Dizi[2
                ]);
            Console.WriteLine(Renkler[0]);

            //Döngülerle Dizi kullanımı
            //Klavyeden girilen n tane sayının ortalmasını hesaplayan program.
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int DiziUzunlugu=int.Parse(Console.ReadLine());
            int[] SayıDizisi=new int[DiziUzunlugu];

            for (int i = 0; i < DiziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısını giriniz.", i+1);
                SayıDizisi[i] = int.Parse(Console.ReadLine());

            }

            int Toplam = 0;
            foreach(var sayi in SayıDizisi)
            {
                Toplam += sayi;
                Console.WriteLine(Toplam);
            }
            Console.WriteLine();
            Console.WriteLine("Ortalama: " +Toplam/DiziUzunlugu);
            Console.Read();

        }
    }
}
