using System;
using System.Collections;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{
    public class Program
    {


        public static void Main(string[] args)
        { 
            int[] dizi=new int[20];
            int[] ek=new int[3];
            int[] eb=new int[3];
            int ekt=0,ebt=0;
            //float eko=0,ebo=0;
            Console.WriteLine("Lütfen 20 sayı giriniz: ");
            for (int i = 0; i < dizi.Length; i++)
            {   
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ",i+1);
                int a=Convert.ToInt32(Console.ReadLine());
                dizi[i]=a;
            }
            Console.WriteLine("Girdiğiniz sayılar şunlardır: ");
            for (int i = 0; i < dizi.Length; i++)
            {   
                Console.WriteLine(dizi[i]);
            }
            Array.Sort(dizi);
            Console.WriteLine("Girdiğiniz en küçük üç sayı: ");
            for (int i = 0; i < 3; i++)
            {   
                ek[i]=dizi[i];
                ekt+=ek[i];
                Console.WriteLine(ek[i]);
            }
            Array.Reverse(dizi);
            Console.WriteLine("Girdiğiniz en büyük üç sayı: ");
            for (int i = 0; i < 3; i++)
            {   
                eb[i]=dizi[i];
                ebt+=eb[i];
                Console.WriteLine(eb[i]);
            }
            Console.WriteLine("Girdiğiniz en küçük üç sayının ortalması: "+ekt/3);
            Console.WriteLine("Girdiğiniz en büyük üç sayının ortalması: "+ebt/3);

        }
    }
}