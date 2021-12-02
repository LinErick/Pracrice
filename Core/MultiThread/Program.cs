using System;
using System.Threading;

namespace MultiThread
{
    delegate void WriteData();
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new(WriteLine);
            //thread1.Start("[a]");

            //Thread thread2 = new(WriteLine);
            //thread2.Start("b");

            //Thread thread3 = new(WriteLine);
            //thread3.Start("/c/");

            Thread threadA = new Thread(new ThreadStart(WriteLineA));
            Thread threadB = new Thread(new ThreadStart(WriteLineB));
            Thread threadC = new Thread(new ThreadStart(WriteLineC));

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        static void WriteLine(object data)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(data);
            }
        }

        static void WriteLineA()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("A");
            }
        }
        static void WriteLineB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("B");
            }
        }
        static void WriteLineC()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C");
            }
        }
    }
}
