using System;
using System.Collections;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calisan c=new Calisan("büşra","kaya",3,"öğrenci");
            c.Calisans();

            Calisan c2=new Calisan("büşra","kaya");
            c2.Calisans();
        }
    }

    class Calisan{
        public string ad;
        public string soy;
        public int yas;
        public string departman;

        public Calisan(string ad,string soy,int yas,string departman){
            this.ad=ad;
            this.soy=soy;
            this.yas=yas;
            this.departman=departman;
        }

        public Calisan(string ad,string soy){
            this.ad=ad;
            this.soy=soy;
        }

        public Calisan(){}

        public void Calisans(){
            Console.WriteLine("calisanın adı {0}",ad);
            Console.WriteLine("calisanın soyadı {0}",soy);
            Console.WriteLine("calisanın yası {0}",yas);
            Console.WriteLine("calisanın depatman {0}",departman);
        }
    }
}