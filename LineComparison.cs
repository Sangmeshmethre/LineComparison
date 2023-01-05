using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUC1
{
    public  class LineComparison
    {
        public static void CalculateLength()
        {
            //Comparing Two Lines L1&L2

            //Frist Part Line Number 1 : L1
            Console.WriteLine("\t\t Enter Value For Line No 1:");
            Console.WriteLine("Enter Value Of : X1 ");
            // String Value Convert To Integer
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of : Y1 ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of : X2 ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of:Y2 ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            //Second Part Line Number 2 :L2
            Console.WriteLine("\t\t Enter Value For Line No 2:");
            Console.WriteLine("Enter Valuve Of :X3 ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Value Of : Y3 ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of : X4 ");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value Of : Y4 ");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            // Using Double To Get Squer Root Value In Double  Decimal Point 
            //Comper To Lines We Neeed 2 Length As L1 & L2
            double Length1 = Math.Sqrt((Math.Pow((X2-X1), 2 ) + Math.Pow((Y2-Y1), 2)));
            Console.WriteLine("Length Of The Line Is : " + Length1 );
            double Length2 = Math.Sqrt((Math.Pow((X4-X3), 2 ) + Math .Pow((Y4-Y3), 2)));
            Console.WriteLine("Length Of The Line Is : " + Length2);

            //Using Sequence Selection To Check The Lines Are Equel Or Not 
            if (Length1 == Length2)
            {
                Console.WriteLine(" BOTH LINE ARE EQUAL");
            }
            else if (Length1>Length2)
            {
                Console.WriteLine("Length1 Is Greater Then Length2");
            }
            else
            {
                Console.WriteLine("Length1 Is Less Then Lenth2 ");
            }
        }
    }
}
