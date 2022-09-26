using BenchmarkDotNet.Running;
using LinqPerformance;

// var item=Enumerable.Range(1,100).ToArray();
//
// var max=item.Max();
// var min = item.Min();
// var average=item.Average();
// var sum=item.Sum();


BenchmarkRunner.Run<Benchmarks>();