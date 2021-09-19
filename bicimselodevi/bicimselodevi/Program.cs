using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bicimselodevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Kaç karakter içericek:");
            n = Convert.ToInt32(Console.ReadLine());
            char[] text = new char[n];
            Console.Write("Texti girin:");
           
            for(int i=0; i<n;i++)
            {
                text[i] = Convert.ToChar(Console.Read());

                if (text[i]=='a' && text[i]=='b')
                {
                    Console.WriteLine("Gecerli");
                }
                else
                {
                    Console.WriteLine("Gecersiz");

                }
                
                Console.WriteLine((i + 1) + ". katar " + text[i]);
            }

            Console.ReadKey();
        }
    }
}
