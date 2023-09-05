using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int border = 2;
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey(true).KeyChar;
            Console.WriteLine(symbol);

            Console.WriteLine(new string(symbol, name.Length + border));
            Console.Write($"{symbol}{name}{symbol}\n");
            Console.WriteLine(new string(symbol, name.Length + border));
        }
    }
}
