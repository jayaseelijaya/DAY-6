using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class dic
    {
        public static void Main()
        {
            Dictionary<int, string> keyvalue = new Dictionary<int, string>();
            keyvalue.Add(1, "jayaseeli");
            keyvalue.Add(2, "jay");
            keyvalue.Add(3, "ja");
            Console.WriteLine(keyvalue[1]);
            
            foreach(var item in keyvalue)
            {
                Console.WriteLine("key=" + item.Key + "\nvalue:" + item.Value);
                Console.ReadLine();
            }
        }
    }
}
