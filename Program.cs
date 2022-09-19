using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDate date = new BaseDate(2021, 3, 24);
            Console.WriteLine(date.GetFormat());
            AmericanDate date1 = new AmericanDate(2021, 3, 24);
            Console.WriteLine(date1.GetFormat());
        }
    }
}
