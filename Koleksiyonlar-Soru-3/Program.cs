using System;
using System.Collections;

namespace CSharpOgretici // Note: actual namespace depends on the project name.
{
    public class Program
    {


        public static void Main(string[] args)
        {
           Console.Write("Enter a sentence : ");
            ArrayList vowel = new ArrayList();
            char[] vowe = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'ö', 'Ö', 'ü', 'Ü', 'ı', 'İ', };
            string letters = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(letters.Length); i++)
            {
                for (int j = 0; j < Convert.ToInt32(vowe.Length); j++)
                {
                    if (letters[i].Equals(vowe[j]))
                    {
                        vowel.Add(letters[i]);
                        Console.WriteLine(letters[i]);
                    }
                }
            }
        }
    }
}