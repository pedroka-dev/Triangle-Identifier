using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleIdentifier.ConsoleApp.Domain;
using TriangleIdentifier.ConsoleApp.View;

namespace TriangleIdentifier.ConsoleApp
{
    class Program
    {
        const bool isTestMode = false;

        static void Main(string[] args)
        {
            if (isTestMode)
            {
                ResultTester();
            }
            else    //menu mode
            {
                MainMenu menu = new MainMenu(ConsoleColor.Yellow);
                menu.DisplayMainMenu();
            }
        }

        private static void ResultTester()      //kinda of a unit test
        {
            Triangle triangle1 = new Triangle(3, 3, 3);
            Console.WriteLine("triangle1 = " + triangle1.IdentifyTriangleType());    //should return "Equilateral"

            Triangle triangle2 = new Triangle(3, 2, 3);
            Console.WriteLine("triangle2 = " + triangle2.IdentifyTriangleType());    //should return "Isoceles"

            Triangle triangle3 = new Triangle(3, 3, 4);
            Console.WriteLine("triangle3 = " + triangle3.IdentifyTriangleType());    //should return "Isoceles"

            Triangle triangle4 = new Triangle(3, 2, 4);
            Console.WriteLine("triangle4 = " + triangle4.IdentifyTriangleType());    //should return "Escalene"

            Triangle triangle5 = new Triangle(3000, 3500, 4000);
            Console.WriteLine("triangle5 = " + triangle5.IdentifyTriangleType());    //should return "Escalene"

            Triangle triangle6 = new Triangle(15, 15, 15);
            Console.WriteLine("triangle6 = " + triangle6.IdentifyTriangleType());    //should return "Equilateral"

            Triangle triangle7 = new Triangle(100000, 100000, 100000);
            Console.WriteLine("triangle7 = " + triangle7.IdentifyTriangleType());    //should return "Equilateral"

            Triangle triangle8 = new Triangle(100000, 1, 1);
            Console.WriteLine("triangle8 = " + triangle8.IdentifyTriangleType());    //should return "Invalid triangle"

            Triangle triangle9 = new Triangle(-2, 3, 5);
            Console.WriteLine("triangle9 = " + triangle9.IdentifyTriangleType());    //should return "Invalid triangle"

            Triangle triangle10 = new Triangle(1, 2, 3);
            Console.WriteLine("triangle10 = " + triangle10.IdentifyTriangleType());    //should return "Invalid triangle"

            Triangle triangle11 = new Triangle(1, 98, 96);
            Console.WriteLine("triangle11 = " + triangle11.IdentifyTriangleType());    //should return "Invalid triangle"

            Console.ReadLine();
        }
    }
}
