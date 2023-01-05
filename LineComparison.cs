using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUC3
{
    public  class LineComparison
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter Value Of :X1");
            //String Value Convert To Integer Value 
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Value Of :Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of: Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            //Using Double To Get Squer Root Value In Double Decimal Point 
            double Length = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2-Y1), 2)));
            Console.WriteLine("Length Of The Line Is :" + Length);

            Console.ReadLine();
        }
    }
}
