﻿using System.Runtime.InteropServices;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using ObjectLayoutInspector;
using Faster.Map.Core;

namespace Faster.Map.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<GetBenchmark>();
        }
    }
}
