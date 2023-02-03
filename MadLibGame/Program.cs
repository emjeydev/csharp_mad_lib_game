using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: MadLibGame
// FileName: MadLibGame
// Date: 2023/02/03
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace MadLibGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
