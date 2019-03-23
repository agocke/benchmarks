using System;
using BenchmarkDotNet.Running;

namespace benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<KindCheck>();
        }
    }
}
