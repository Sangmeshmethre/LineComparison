using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUC4
{
    public  class LineComparison
    {
        public static void  LineLength()
        {
            double Length1 = 0; 
            double Length2 = 0;

            Console.WriteLine("Please Enter The Value of X1 And X2 as :");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X1:" + X1);
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2:" +X2);
            Console.WriteLine("Please Enter The Value Of Y1 And Y2 as :");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1:" + Y1);
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2:" + Y2);
            
            Console.WriteLine("Please Enter The Value of X3 And X4 as :");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X3:" + X3);
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X4:" + X4);
            Console.WriteLine("Please Enter The Value Of Y3 And Y4 as :");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y3:" + Y3);
            int Y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y4:" + Y4);


            // To Calculate  Length Of Line Using Math Class
            double Lenght1 = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2-Y1), 2)));
            double Lenght2 = Math.Sqrt((Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2)));
            Console.WriteLine("Length Of The Line is :" + Lenght1);
            Console.WriteLine("Length Of The Line is :" + Lenght2);
            Console.WriteLine("Checking For The Points Are Equal Or Not");

            if (Length1.CompareTo(Lenght2)==0) 
                Console.WriteLine("Points Are Equal");
            else
                Console.WriteLine("Point Are Not Equal");
        }
    }
}
