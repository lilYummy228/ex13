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
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(new string(symbol, name.Length + 2));
            Console.Write($"{symbol}{name}{symbol}\n");
            Console.WriteLine(new string(symbol, name.Length + 2));

            for (int i = 0; i < (name.Length + 2); i++)
            {
                Console.Write(symbol);
            }

            Console.Write($"\n{symbol}{name}{symbol}\n");

            for (int i = 0; i < (name.Length + 2); i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
