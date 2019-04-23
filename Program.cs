using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void show( int val)
        {
            val *= val;
            Console.WriteLine("The value is " + val);
        }
        static void Main(string[] args)
        {
            int val = 10;
            Program abc = new Program();
            Console.WriteLine("Value before ref " + val);
            abc.show(val);
            Console.WriteLine("Value After ref " + val);
            Console.ReadLine();

        }
    }
}
