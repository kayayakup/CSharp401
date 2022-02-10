using System;
using System.Collections;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{

    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }

    public class seald:Canlilar
    {
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            seald sld=new seald();
            sld.UyaranlaraTepki();
        }
    }
}