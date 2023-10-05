using System;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace BigONotationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // BenchmarkRunner.Run<BigOBenchmarks>();

            // Example usage
            MyClass myObject = new MyClass { MyString = null };
            string json = JsonConvert.SerializeObject(myObject);
            Console.WriteLine(json); // Output: {"MyString":""}
        }
    }
}
