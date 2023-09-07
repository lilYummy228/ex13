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
            char symbol = Console.ReadKey(true).KeyChar;
            Console.WriteLine(symbol);
            string middleLine = $"{symbol}{name}{symbol}";
            string frame = new string(symbol, middleLine.Length);

            Console.WriteLine($"\n{frame}");
            Console.Write(middleLine);
            Console.WriteLine($"\n{frame}");
        }
    }
}
