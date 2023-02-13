using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //static void Add() Metot tur
        //{
        //    Console.WriteLine("added!");
        //}

        static void Main(string[] args)
        {
            int result = Add2(10, 20);
            Console.WriteLine(result);
            int number1 = 10;
            int number2 = 20;  
            var result1 = Add3(number1, number2);
            Console.WriteLine(result1);
            Console.WriteLine(number1);  // fonksiyonda number 1 e yeni değer atadık gibi gözüküyor fakat aslında biz sadece sayıyı değiştirdik
                                         // hem sayı hem number1 i değiştirmek istiyorsak ref keyword kullanmalıyız (referans)
            var result2 = Add4(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);  // referans sayesinde metodumuzdaki değişikliği kaydetmiş olduk gibi birşey

            var result3 = Add5(1, 2, 3, 4, 5, 6, 7); // params kullandık
            Console.WriteLine(result3);
            Console.ReadLine();         
        }

        static int Add2(int number1, int number2 = 20) // =20 ifadesi default parametre oluyor değer tanımlamamışssak number 2 yi 20 sayıyor
        {
            return number1 + number2;
        }

        static int Add3( int number1, int number2) 
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add5(params int[] numbers) // params ile birden çok istediğimiz kadar sayıyı fonksiyona atayabiliyoruz
        {
            return numbers.Sum(); // kalıp ifadedir girilen tüm sayıları toplayıp return yapmayı sağladı
        }
    }
}
