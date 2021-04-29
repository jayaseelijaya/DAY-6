using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Class1
    {


        public static void Main()
        {

            Dictionary<int, string> sortedList = new Dictionary<int, string>();
            sortedList.Add(1, "Dog");
            sortedList.Add(2, "Cat");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Key is : " + item.Key + "Value is : " + item.Value);
            }
            SortedList<int, string> keyValues = new SortedList<int, string>();
            keyValues.Add(1, "NASA");
            keyValues.Add(2, "ISRO");
            keyValues.Add(3, "CNSA");
            foreach (var item in keyValues)
            {
                Console.WriteLine("RANK is :" + item.Key + " Value is : " + item.Value);
            }

        }
    }
}
