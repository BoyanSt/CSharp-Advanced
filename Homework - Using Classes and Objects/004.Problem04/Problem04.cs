using System;

class Problem04
{
    static void Main()
    {
        Console.WriteLine("Please enter side of the trange.");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter altitude to the side.");
        double h = double.Parse(Console.ReadLine());
        double area01 = TriangleArea(side, h);
        Console.WriteLine("The area of trainge is {0:F2}", area01);

        Console.WriteLine("Please enter the three sides of the triangle separated by space");
        string input = Console.ReadLine();
        string[] inputAsStrArr = input.Split();
        double siteA = double.Parse(inputAsStrArr[0]);
        double siteB = double.Parse(inputAsStrArr[1]);
        double siteC = double.Parse(inputAsStrArr[2]);
        double area02 = TriangleAreaThreeSides(siteA, siteB, siteC);
        Console.WriteLine("The area of trainge is {0:F2}", area02);

        Console.WriteLine("Please enter side a of the trange.");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side b of the trange.");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the angle in degrees between the two sides.");
        double angle = double.Parse(Console.ReadLine());
        double area03 = TriangleAreaTwoSidesAngle(sideA, sideB, angle);
        Console.WriteLine("The area of trainge is {0:F2}", area03);

    }
    static double TriangleArea(double side, double h)
    {
        double area = (side * h)/2;
        return area;
    }
    static double TriangleAreaThreeSides(double siteA, double siteB, double siteC)
    {
        double halfPerimeter = (siteA + siteB + siteC) / 2;
        double area = Math.Sqrt(halfPerimeter*(halfPerimeter-siteA)*(halfPerimeter-siteB)*(halfPerimeter-siteC));
        return area;
    }
    static double TriangleAreaTwoSidesAngle(double sideA, double sideB, double angle)
    {
        double area = (sideA * sideB * Math.Sin(angle*(Math.PI/180))) / 2;
        return area;
    }
}

