using System;
using System.Collections;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{
    public class Program
    {

        
        public static void Main(string[] args)
        {

            static bool asalmi(int sayi)
        {
            bool durum = false;
 
            int kontrol = 0;
 
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) //www.yazilimkodlama.com
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum= false;
            }
            else
            {//www.yazilimkodlama.com
                durum= true;
            }
 
            return durum;
        }

            // int[] sayiDizisi = { 1, 3, 4, 9, 8, 7 };
            // Array.Resize<int>(ref sayiDizisi, 12);
            // sayiDizisi[6] = 10;


            ArrayList sayilar = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalolmayan = new ArrayList();
            int asaltoplam=0, asalolmayantoplam=0;
            float asalort=0, asalolmayanort=0;
            for (int i = 0; i < 20; i++)
            {   
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                int c = Convert.ToInt32(Console.ReadLine());
                int s=Math.Abs(c);
                sayilar.Add(s);
                if (asalmi(s)==true)
                {
                    if(s==1)
                    {
                        asalolmayantoplam+=asalolmayan.Add(s); 
                    }
                    asaltoplam+=asal.Add(s);
                } 
                else
                    asalolmayantoplam+=asalolmayan.Add(s);                    
            }
            asal.Remove(1);
            sayilar.Sort();
            asal.Sort();
            asalolmayan.Sort();
            int a=asalolmayan.Count;
            int b=asal.Count;
            if(a==0){
                a=1;
            }
            if(b==0){
                b=1;
            }
            asalolmayanort=asalolmayantoplam/a;
            asalort=asaltoplam/b;
            Console.WriteLine("Girdiğiniz tüm sayılar: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("("+sayilar[i]+")"); 
            }
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz asal sayılar: ");
            for (int i = 0; i < b; i++)
            {
                Console.Write("("+asal[i]+")"); 
            }
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz asalolmayan sayılar: ");
            for (int i = 0; i < a; i++)
            {
                Console.Write("("+asalolmayan[i]+")"); 
            }

        }
    }
}