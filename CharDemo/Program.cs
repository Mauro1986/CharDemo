using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //char someLetter = 'a';
            //char someSymbol = '#';
            //char anotherOne = '?';

            //Console.WriteLine(someLetter+"" + someSymbol+ anotherOne);      //zonder de  " " zal hij andere uitkomst geven
            //Console.WriteLine();


            //Console.WriteLine("Geef tekst");
            //string input = Console.ReadLine();
                
            //char inputSymbol = input[0];
            //Console.WriteLine(inputSymbol);

            //inputSymbol = input[2];
            //Console.WriteLine(inputSymbol);


            //char someChar = '8';

            //if (char.IsDigit(someChar))
            //{
            //    Console.WriteLine("SomeChar is Digit");
            //}
            //else
            //{
            //    Console.WriteLine("SomeChar is NOT Digit");
            //}

            //char someChar2 = '7';

            //if (char.IsLetter(someChar))
            //{
            //    Console.WriteLine("SomeChar is Letter");
            //}
            //else
            //{
            //    Console.WriteLine("SomeChar2 is NOT Letter");
            //}

            //if ('a' < 'f')                                                  //Handig om alfabetisch 
            //{ Console.WriteLine("True"); 
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}


            
            //for (char kar = 'a';  kar <= 'z'; kar++)     // Volledige Alfabet  (ofwel allebei kleine of allebei grote letters)
            //{
            //    Console.WriteLine(kar);
            //}
            char letter = 'x';
            //Console.WriteLine(+ letter );     //geeft ook unicode
            Console.WriteLine((int)letter);

        }
    }
}
