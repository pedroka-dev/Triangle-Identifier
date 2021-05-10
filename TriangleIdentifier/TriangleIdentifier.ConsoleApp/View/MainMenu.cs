using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleIdentifier.ConsoleApp.Domain;

namespace TriangleIdentifier.ConsoleApp.View
{
    class MainMenu
    {
        private ConsoleColor fontColor;

        public MainMenu(ConsoleColor fontColor)
        {
            this.fontColor = fontColor;
        }

        private void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = fontColor;
            Console.WriteLine("-@-@-@-@-@-@ TRIANGLE IDENTIFIER -@-@-@-@-@-@");
        }

        private void DisplayError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!!! {text} !!!");
            Console.ForegroundColor = fontColor;
        }

        private void DisplayTriangle(Triangle triangle)
        {
            Console.WriteLine(" - Triangle type = " + triangle.IdentifyTriangleType());
            Console.WriteLine(" - Side X = " + triangle.SideX);
            Console.WriteLine(" - Side Y = " + triangle.SideY);
            Console.WriteLine(" - Side Z = " + triangle.SideZ);
        }

        public void DisplayMainMenu()
        {
            while (true)
            {
                DisplayHeader();
                Console.WriteLine(" - This program can verify if a triangle is a isosceles, equilateral, scalene or invalid.");
                Console.WriteLine(" - Do you want to enter the values of a new triangle? (y/n)");
                string userInput = Console.ReadLine().ToLowerInvariant();

                if (string.Equals(userInput, "y"))
                    DisplayEnterTriangleMenu();
                else if (string.Equals(userInput, "n"))
                    break;
            }
        }

        private void DisplayEnterTriangleMenu()
        {
            while (true)
            {
                DisplayHeader();
                Console.WriteLine(" - Enter the value of the side X:");
                string inputX = Console.ReadLine();
                Console.WriteLine(" - Enter the value of the side Y:");
                string inputY = Console.ReadLine();
                Console.WriteLine(" - Enter the value of the side X:");
                string inputZ = Console.ReadLine();

                if (float.TryParse(inputX, out float sideX) && float.TryParse(inputY, out float sideY) && float.TryParse(inputZ, out float sideZ))
                {
                    Triangle triangle = new Triangle(sideX, sideY, sideZ);
                    DisplayHeader();
                    DisplayTriangle(triangle);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    DisplayError("All sides must be valid floats values.");
                    Console.ReadLine();
                }
            }
        }
    }
}
