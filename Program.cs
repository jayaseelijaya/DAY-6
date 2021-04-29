using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Program
    {
     /*   public static Tuple<int, int,double,double,double> calculator(int a, int b)
        {
            return new Tuple<int,int,double,double,double>((a + b), (a - b),(a*b),(a/b),(a%b));
        }*/

        static void Main()
        {
            //  Tuple<int, int, double, double,double> o = Program.calculator(10,2);
            // Console.WriteLine("addition=" + o.Item1 + "\nsubraction =" + o.Item2+"\nmul ="+o.Item3+"\ndiv ="+o.Item4+"\nmod ="+o.Item5);
            Tuple<int, int, int, int, int, int, int, int> tuple = new tuple<int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
            Console.ReadLine();


        }
    }

}