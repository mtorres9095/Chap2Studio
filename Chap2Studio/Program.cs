using System;

namespace Chap2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double pi = 3.14;
            double radius;
            string input1;
            double circum;
            double diameter;
            string input2;
            double miles;
            double gasUsed;

            // Studio part I Calculate the Area of a Circle
            Console.WriteLine("Enter a radius: ");
            input1 = Console.ReadLine();
            radius = double.Parse(input1);
            area = pi * radius * radius;
            Console.WriteLine("The area of a circle of " + radius + " is: " + area);
            
            // Studio part II More calculations
            circum = (2 * pi * radius);
            diameter = (2 * radius);
            Console.WriteLine("The circumference is: " + circum);
            Console.WriteLine("The diameter is: " + diameter);

            // Studio Part III Road Trips
            Console.WriteLine("Enter the amount of Gallons of Gas used: ");
            input2 = Console.ReadLine();
            miles = double.Parse(input2);
            gasUsed = circum / miles;
            Console.WriteLine("You used "+ gasUsed + " to go around the circle");




        }
    }
}
