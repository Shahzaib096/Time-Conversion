using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Time You Want To Convert :");
            DateTime d = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Converted Time iS :" + d.ToString("HH:mm::ss"));
            Console.ReadLine();
        }
    }
}
