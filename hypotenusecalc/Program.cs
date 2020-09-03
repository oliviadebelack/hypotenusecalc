using System;

namespace trianglehw
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            double hypt;
            string temp;

            Console.WriteLine("Calculate The Hypotenuse Of Your Right Triangle. Press Enter to Begin! ");
            //read in side 1
            temp = Console.ReadLine();
            side1 = getInt("Enter the Length of Side 1: ");


            //read in the gallons
            Console.WriteLine("Enter the Length of Side 2: ");
            temp = Console.ReadLine();
            side2 = Double.Parse(temp);

            //compute mpg
            hypt = Math.Sqrt(side1 * side1 + side2 * side2);
            Console.WriteLine("The Hypotenuse of Your Triangle Is " + hypt);

        }
        public static int getInt(string prompt)
        {
            string temp;
            int value;
            Console.WriteLine(prompt);
            temp = Console.ReadLine();
            value = Int32.Parse(temp);
            return value;


        }

    }
}
