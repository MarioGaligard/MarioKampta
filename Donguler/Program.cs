﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            // string kurs2 = "Programlamaya başlangıç için temel kurs";
            // string kurs3 = "Java";
            // string kurs4 = "Python";
            // string kurs5 = "C++";
            // string kurs6 = "C#";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C++", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer ");
        }
    }
}
