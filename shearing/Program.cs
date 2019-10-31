using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shearing
{
    class Program
    {
        static void Main(string[] args)
        {

            int sh;
            int opt;
            int x;
            int y;
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
            int x4;
            int y4;
           
            Console.WriteLine("**************************Shearing*******************************");
            Console.WriteLine("Please Enter \n1)For x-Shearing\n2)For y-Shearing");
            opt = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Units of Shearing");
            sh = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n\nEnter The Value of x1 :");
            x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y1 :");
            y1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x2 :");
            x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y2 :");
            y2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x3 :");
            x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y3 :");
            y3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x4 :");
            x4 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y4 :");
            y4 = Int16.Parse(Console.ReadLine());
            if (opt == 1)
            {
                y = y1;
                x = x1 + sh * y;
                Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
                y = y2;
                x = x2 + sh * y;
                Console.WriteLine("Second Point is  (" + x + "," + y + ")");
                y = y3;
                x = x3 + sh * y;
                Console.WriteLine("Third Point is  (" + x + "," + y + ")");
                y = y4;
                x = x4 + sh * y;
                Console.WriteLine("Fourth Point is  (" + x + "," + y + ")");
            }
            else if (opt == 2)
            {

                x = x1;
                y = y1 + sh * x;
                Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
                x = x2;
                y = y2 + sh * x;
                Console.WriteLine("Second Point is  (" + x + "," + y + ")");
                x = x3;
                y = y3 + sh * x;
                Console.WriteLine("Third Point is  (" + x + "," + y + ")");
                x = x4;
                y = y4 + sh * x;
                Console.WriteLine("Fourth Point is  (" + x + "," + y + ")");
            }
            Console.ReadLine();
        }
    }
}
