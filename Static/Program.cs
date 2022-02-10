using System;
using System.Collections;

namespace Static
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Toplama sonucu: {0}",Islemler.topla(350,50));
            Console.WriteLine("Çıkarma sonucu: {0}",Islemler.cıkar(350,50));
        }
    }

    static class Islemler{

        public static int topla(int a,int b){
            return a+b;
        }

        public static int cıkar(int a,int b){
            return a-b;
        }
    }
    
}