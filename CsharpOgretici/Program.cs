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
            //Temel C# operatorleri
            /*Console.WriteLine("Hello World!");

            Console.WriteLine("Adınızı girin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı girin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba "+name+ " " +surname);*/

            /*byte b = 5; //1 byte
            sbyte c = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte
            Int16 i16 = 2; //2 byte

            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte

            //Reel sayılar
            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char ch = '2'; //2 byte
            string str = "Yakup KAYA"; //sınırsız byte kullanabilir

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1=string.Empty;
            str1="Yakup KAYA";
            string ad="Yakup";
            string soyad="KAYA";
            string tamIsim=ad+""+soyad;

            //integer tanımlama şekilleri

            int integer1=5;
            int integer2=3;
            int integer3=integer1*integer2;

            //boolean

            bool bool1 = 10>2;

            //Değişken Dönüşümleri

            string str20="20";
            int int20=20;

            string yeniDeger=str20+int20.ToString();

            Console.WriteLine(yeniDeger); //Çıktısı 2020 olacaktır.

            int int21=int20+Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40 olacaktır.

            int int22 = int20+int.Parse(str20); //Çıktısı 40 olacaktır.

            // datetime

            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour=DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(hour);*/

            //Diziler
            /*string[] colors= new string[5];
            string[] hayvanlar= {"kedi","köpek","kuş","maumun"};
            int[] dizi;
            dizi=new int[5];
            colors[0]="mavi";
            dizi[3]=10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(colors[0]);
            Console.WriteLine(dizi[3]);*/

            /*Console.WriteLine("lutfen dizinin uzunlugunu giriniz: ");
            int diziuzunlugu= Convert.ToInt32(Console.ReadLine());
            int[] dizi=new int [diziuzunlugu];

            for(int i=0;i<diziuzunlugu;i++){
                Console.WriteLine("Lutften {0}. sayıyı giriniz: ",i+1);
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }

            //Methodlar
            int toplam=0;
            foreach (var sayi in dizi){
                toplam+=sayi;
            }

            Console.WriteLine("Ortalama: {0}",toplam/diziuzunlugu);*/

            // int x=13,y=30;
            // int q=9;
            // string a="Yakup",sa="KAYA";
            // toplama orn=new toplama();
            // static int topla(int a,int b){
            //     return a+b;
            // }
            // //Console.WriteLine(topla(x,y));
            // int inte=orn.toplam(ref x,ref y);
            // Console.WriteLine(inte);

            // orn.topla(x,y);
            // orn.topla(q);
            // orn.topla(a,sa);

            //extension call
            // string ifade = "yakup kaya";
            // Console.WriteLine(ifade.ilkharf());

            // Console.Write("Lütfen dizi uzunluğunu giriniz: ");
            // int n=Convert.ToInt32(Console.ReadLine());
            // if (n<0)
            // {
            //     Console.Write("Lütfen pozitif bir sayı giriniz: ");
            //     n=Convert.ToInt32(Console.ReadLine());
            // }

            //1.soru
            // int[] dizi=new int[n];
            // for (int i = 0; i < dizi.Length; i++)
            // {
            //     int a =Convert.ToInt32(Console.ReadLine());
            //     dizi[i]=a;
            // }
            // Console.WriteLine("Girdiginiz cift sayilar sunlardir");
            // for (int i = 0; i < dizi.Length; i++)
            // {
            //     if (dizi[i]%2==0)
            //     {
            //         Console.WriteLine(dizi[i]);
            //     }
            // }

            //2. soru
            // Console.Write("İki tane sayı giriniz: ");
            // int n,m;
            // n=Convert.ToInt32(Console.ReadLine());
            // m=Convert.ToInt32(Console.ReadLine());
            // if (n<0&&m<0)
            // {
            //     Console.Write("İki tane pozitif sayı giriniz: ");
            //     n=Convert.ToInt32(Console.ReadLine());
            //     m=Convert.ToInt32(Console.ReadLine());
            // }
            // int[] dizi=new int[n];
            // for (int i = 0; i < dizi.Length; i++)
            // {   
            //     Console.Write("Lütfen "+n+" tane sayı giriniz: ");
            //     int a =Convert.ToInt32(Console.ReadLine());
            //     dizi[i]=a;
            // }
            // for (int i = 0; i < dizi.Length; i++)
            // {
            //     if ((dizi[i]==m)||(dizi[i]%m==0))
            //     {
            //         Console.WriteLine(dizi[i]);
            //     }
            // }

            //3. soru
            // Console.Write("bir sayı giriniz: ");
            // int n=Convert.ToInt32(Console.ReadLine());
            // Math.Abs(n);
            // string[] array=new string[n];
            // Console.Write("lutfen "+n+" tane kelime giriniz: ");
            // for (int i = 0; i < array.Length; i++)
            // {
            //     string word;
            //     word=Console.ReadLine();
            //     array[i]=word;
            // }
            // Console.WriteLine("girdiginiz kelimeler sunlardır: ");
            // for (int i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine(array[i]);
            // }

            //4. soru
            // Console.Write("Bir cumle giriniz: ");
            // string sentence=Console.ReadLine();
            // int sayac=0;
            // for (int i = 0; i < sentence.Length; i++)
            // {
            //     sayac++;
            // }
            // Console.WriteLine("cumlenin uznlugu= "+sayac);

            // string[] kelimeler = sentence.Split(' ');
            // Console.WriteLine("Kelime Sayısı= "+kelimeler.Length);
            // foreach(string kelime in kelimeler)
            // {
            //     Console.WriteLine(kelime);
            // }

            List<Kullanicilar> Kullanicilistesi=new List<Kullanicilar>();
            Kullanicilar kullanici1=new Kullanicilar();

            kullanici1.Isim="Ukuo";
            kullanici1.SoyIsim="kuo";
            kullanici1.Yas=20;

            Console.WriteLine(kullanici1.Isim);
            Console.WriteLine(kullanici1.SoyIsim);
            Console.WriteLine(kullanici1.Yas);

        }

        class toplama
        {
            //overloadin işlemleri
            // public int toplam(ref int deger1,ref int deger2){
            //     deger1+=1;
            //     deger2+=5;

            //     return deger1+deger2;
            // }

            // public void topla(int a, int b){
            //     int sonuc=a+b;
            //     Console.WriteLine(sonuc);
            // }

            // public void topla(int q){
            //     Console.WriteLine(q);
            // }

            // public void topla(string a,string b){
            //     string sonuc=a+b;
            //     Console.WriteLine(sonuc);
            // }

            
        }

    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

    //extencion class
    // public static class Extension
    // {
    //     public static string ilkharf(this string text)
    //     {
    //         string ilk = text.Substring(3, 7);
    //         return ilk;
    //     }
    // }
}