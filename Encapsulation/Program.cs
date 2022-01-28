using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ogrenci o=new Ogrenci("Yakup","Kaya",64685,2);
            o.ogrencibilgilerinigetir();

            Ogrenci o1=new Ogrenci("gbrsbs","aya",64685,0);
            o1.sınıfatlat();
            o1.sınıfdusur();
            o1.ogrencibilgilerinigetir();
        }

        class Ogrenci
        {
            private string name;
            private string surname;
            private int number;
            private int clas;

            public string Name{ get {return name;} set{ name = value;} }

            public string Surname { get => surname; set => surname = value; }
            public int Number { get => number; set => number = value; }
            public int Clas { get => clas; set{
                if(value<1){
                    Console.WriteLine("sınıf en az 1 olabilir");
                    clas=1;
                }
                else{
                    clas=value;
                }
            } }

            public Ogrenci(string name,string surname, int number,int clas){
                Name=name;
                Surname=surname;
                Number=number;
                Clas=clas;
            }

            public Ogrenci(){}

            public void ogrencibilgilerinigetir(){
                Console.WriteLine("Öğrecinin adı: "+name);
                Console.WriteLine("Öğrecinin soyadı: "+surname);
                Console.WriteLine("Öğrecinin numarası: "+number);
                Console.WriteLine("Öğrecinin sınıfı: "+clas);
            }

            public void sınıfatlat(){
                this.Clas+=1;
            }

            public void sınıfdusur(){
                this.Clas-=1;
            }
        }
    }
}