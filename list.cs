using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class list
    {
        public static void Main()
        {
            List<int> mylist = new List<int>() { 54, 46, 7, 5, 4 };
            foreach (var a in mylist)
            {
               
                    if (a % 2 == 0)
                    {

                        Console.WriteLine("even numbers are" + a);
                    } 
                    else
                    {
                Console.WriteLine("odd numbers" + a);
            }
                }
            
            Console.ReadLine();
        }
    }

}

   


