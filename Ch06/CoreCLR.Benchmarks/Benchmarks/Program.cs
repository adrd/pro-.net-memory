using System;
using System.Diagnostics;
using System.Threading;
using BenchmarkDotNet.Running;
using Benchmarks.Tests;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var benchmark = BenchmarkRunner.Run<StructVsClassTest>();
            //var benchmark = BenchmarkRunner.Run<ValueTuples>();
            //var benchmark = BenchmarkRunner.Run<JsonArrayPoolTest>();
            //var benchmark = BenchmarkRunner.Run<RecyclableMemoryStreamTest>();
            var benchmark = BenchmarkRunner.Run<ObjectPoolTest>();
 
            Console.WriteLine("Benchmark finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
