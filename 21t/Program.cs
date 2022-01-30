using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21t
{
    class Program
    {
        const int n = 3;
        static int[,] garden = new int[n, n];

        static void Gardener1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; i++)
                {
                    if (garden[i, j] != 2)
                    {
                        garden[i, j] = 1;
                    }
                }
            }
        }
        static void Gardener2()
        {
            for (int j = n; j < 0; j--)
            {
                for (int i = n; i < 0; i--)
                {
                    if (garden[i, j] != 1)
                    {
                        garden[i, j] = 2;
                    }
                }
            }
                    }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardener2();
        }

    }

}
