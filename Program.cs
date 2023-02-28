using System;
using oopLab1;

class Application
{
    static int x1, y1, x2, y2, x3, y3, x4, y4;

    public static void Main(String[] args)
    {

        while (true)
        {
            menu();
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    consoleInputCalculationArea();
                    break;
                case 2:
                    consoleInputCalculationPerimeter();
                    break;
                case 3:
                    array();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You can not use " + num);
                    break;

            }


        }
    }

    public static void menu()
    {
        Console.WriteLine("Press 1 - to calculate the area of ​​the rhombus");
        Console.WriteLine("Press 2 - to calculate the perimeter of the rhombus");
        Console.WriteLine("Press 3 - to create array");
        Console.WriteLine("Press 0 - to exit the program");

    }

    public static void consoleInputCalculationArea()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses rhombuses = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine("Rhombus square = " + rhombuses.squareRhombuses());
    }

    public static void consoleInputCalculationPerimeter()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses rhombuses2 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine("Perimeter = " + rhombuses2.perimeterRhombuses());
    }

    public static void array()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses[] rhombArray = new Rhombuses[17];

        for (int i = 0; i < rhombArray.Length / 2; i++)
        {
            rhombArray[i] = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
            rhombArray[rhombArray.Length - i - 1] = new Rhombuses(
                rhombArray[i].getX4(), rhombArray[i].getY4(),
                rhombArray[i].getX3(), rhombArray[i].getY3(),
                rhombArray[i].getX2(), rhombArray[i].getY2(),
                rhombArray[i].getX1(), rhombArray[i].getY1()
            );
        }

        for (int i = 0; i < rhombArray.Length; i++)
        {
            Console.WriteLine(rhombArray[i]);
        }


    }

  
}



