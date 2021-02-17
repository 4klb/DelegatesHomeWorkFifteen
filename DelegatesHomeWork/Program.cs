using Models;
using System;

namespace DelegatesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ConsoleButton
            {
                Boundary = "-",
                Width = 8,
                Height = 20,
                Text = "Button",
                InsideColor = ConsoleColor.Red,
                BoundaryColor = ConsoleColor.Yellow,
                Action = new ActionDelegate(Console.WriteLine)
            };
            service.Button();
            service.Action += new ActionDelegate(Console.WriteLine);
            service.Action -= new ActionDelegate(Console.WriteLine);
        }
    }
}
