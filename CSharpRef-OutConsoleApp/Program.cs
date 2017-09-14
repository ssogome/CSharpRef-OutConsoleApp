using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRef_OutConsoleApp
{
    class Program
    {
        //Using Out
        public static int GetIntWithOut(out int i)
        {
            i = 12;
            return i;
        }

        public static int GetIntWithRef(ref int i)
        {
            return i;
        }

        static void Main(string[] args)
        {
            int n; //No need for initialization when using out
            int m = 9; //Need initialization before using it with ref

            Console.WriteLine("The value held by n using 'out' is: {0}\n", GetIntWithOut(out n));
            Console.WriteLine("The value held by m using 'ref' is: {0}\n", GetIntWithRef(ref m));
            
            Console.ReadKey();
        }
    }
}
