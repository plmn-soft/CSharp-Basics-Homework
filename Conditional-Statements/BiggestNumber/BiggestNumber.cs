using System;

class BiggestNumber
{
    static void Main()
    {
        //Declare variables
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        //Compare variables and print result
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
        }

        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine(b);
            }
        }

        else if (c > a)
        {
            if (c > b)
            {
                Console.WriteLine(c);
            }
        }
    }
}
