using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 밑 줄 15
            for (int i = 0; i < 8; i++) // 중간이 8
            {
                for (int j = 7; j > i; j--)
                {
                    Console.Write(" ");
                } // i = 0

                for (int k = 0; k < (i*2) + 1; k++) // k = 1 처음에 k 가 1이라서 *을 하나만 찍는다.
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
