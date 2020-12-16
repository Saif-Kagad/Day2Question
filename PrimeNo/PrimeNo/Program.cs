using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max,flag;
            Console.WriteLine("Enter min number");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max number");
            max = int.Parse(Console.ReadLine());
            for(int i=min+1;i<max;++i)
            {
                flag = 0;
                for(int j=2;j<i/2;++j)
                {
                    if(i%j ==0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("sairamreddy");
        }
    }
}
