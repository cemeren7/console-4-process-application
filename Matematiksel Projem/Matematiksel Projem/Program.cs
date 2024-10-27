using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Projem
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayı1, sayı2,sayı3;
            double sonuc;
            string islem;
            Console.Write("**** Sayı Hesaplama Programı **** \n");
            Console.Write("\n");
            adım6:
            Console.Write("1. Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz:  ");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.Sayıyı Giriniz:  ");
            sayı3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yapmak İstediğiniz İşlemin Sembolünü veya Adını Girin: ");
            islem = Console.ReadLine();

            if (islem=="+" || islem=="toplam" || islem=="Toplam")
            {
                sonuc = sayı1 + sayı2 + sayı3;
                Console.WriteLine("Girdiginiz Sayıların Toplamı: " + sonuc);
            }
            if (islem=="-" || islem=="fark" || islem=="Fark")
            {
                sonuc = sayı1 - sayı2 - sayı3;
                Console.WriteLine("Girdiginiz sayılar Arasındaki Fark: " + sonuc);
            }
            if (islem=="*" || islem=="çarpım" || islem=="Çarpım")
            {
                sonuc = sayı1 * sayı2 * sayı3;
                Console.WriteLine("Girdiginiz sayıların çarpımı: " + sonuc);
            }
            if (islem=="/" || islem=="Bölüm" || islem=="bölüm")
            {
                sonuc = sayı1 / sayı2 / sayı3;
                Console.WriteLine("Girdiginiz sayıların Bölümü: " + sonuc);
            }
            if (islem=="//" || islem=="Ort" || islem=="Ortalama")
            {
                sonuc = (sayı1 + sayı2 + sayı3) / 3;
                Console.WriteLine("Girdiginiz sayıların ortalaması: " + sonuc);
            }
            Console.WriteLine();
            Console.Write("Yeni Bir İşlem Yapmak İçin Herhangi bir tuşa basınız:  ");
            Console.ReadKey();
            Console.Clear();
            goto adım6;
        }
    }
}
