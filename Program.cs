using System;
using BenchmarkDotNet.Running;

namespace BigONotationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BenchmarkRunner.Run<BigOBenchmarks>();
        }
    }
}
