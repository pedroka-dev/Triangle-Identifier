using System;
using TriangleIdentifier.ConsoleApp.View;

namespace TriangleIdentifier.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu(ConsoleColor.Yellow);
            menu.DisplayMainMenu();
        }
    }
}
