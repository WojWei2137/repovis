using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthname =
            {
                "styczeń",
                "luty",
                "marzec",
                "kwiecień",
                "maj",
                "czerwiec",
                "lipiec",
                "sierpień",
                "wrzesień",
                "październik",
                "listopad",
                "grudzień"
            };

            Console.WriteLine(monthname[0]);
            foreach (string month in monthname)
            {
                Console.WriteLine(month);
            }
            foreach (string month in monthname) { 
                Console.WriteLine(month);
            }
            

            Console.WriteLine("1-styczeń, 2-luty, 3-marzec, itd.");
            Console.Write("podaj numer miesiąca: ");

            int choosenMonth = int.Parse(Console.ReadLine());
            Console.WriteLine($"miesiąc: {monthname[choosenMonth - 1]}");

        }
    }
}
