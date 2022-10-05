using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_even_between_20_to_100_by_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int i = 20;
            while(i<=100)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
