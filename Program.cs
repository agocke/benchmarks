using System;
using BenchmarkDotNet.Running;

namespace benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<DynamicDispatch>();
        }
    }
}
