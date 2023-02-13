using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeandvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type değişken tipleri
            Console.WriteLine("Hello World");
            double number5 = 10.4;
            decimal number6 = 10.4M;// virgülden sonra 20 den fazla karakter tutabiliyor
            char character = 'A';
            bool condition = false; //conditions(koşul) bool ise koşulun true yada false olduğuna bakar
            byte number4 = 255; // 0 - 255 arası sayı tutar
            short number3 = 12345; //16 bit
            int number1 = 10; //32 bit
            long number2 = 2000000060;//64 bit
            Console.WriteLine(number1);
            Console.WriteLine("Number is {1} ", number1,number2); // {1} indeks'tir virgülden sonraki 1. dı değeri ifade eder
            Console.WriteLine("character is {0}", (int)character); // int yazarak a harfinin ascll deki karşılığını görmüş olduk 
            Console.WriteLine("Number is {0} ",number5 );
            Console.ReadLine();
        }
    }
}
