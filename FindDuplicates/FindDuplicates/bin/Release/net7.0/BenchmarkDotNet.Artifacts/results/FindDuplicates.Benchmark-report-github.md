``` ini

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]   : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX
  .NET 7.0 : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX


```
|       Method |      Job |  Runtime | Size |     Mean |     Error |    StdDev |   Median | Allocated |
|------------- |--------- |--------- |----- |---------:|----------:|----------:|---------:|----------:|
|      Foreach | .NET 6.0 | .NET 6.0 |  100 |       NA |        NA |        NA |       NA |         - |
|      LinqAny | .NET 6.0 | .NET 6.0 |  100 |       NA |        NA |        NA |       NA |         - |
|      LinqAll | .NET 6.0 | .NET 6.0 |  100 |       NA |        NA |        NA |       NA |         - |
| LinqDistinct | .NET 6.0 | .NET 6.0 |  100 |       NA |        NA |        NA |       NA |         - |
|    ToHashSet | .NET 6.0 | .NET 6.0 |  100 |       NA |        NA |        NA |       NA |         - |
|      Foreach | .NET 7.0 | .NET 7.0 |  100 | 2.865 μs | 0.0566 μs | 0.1312 μs | 2.834 μs |    2824 B |
|      LinqAny | .NET 7.0 | .NET 7.0 |  100 | 3.031 μs | 0.0600 μs | 0.1415 μs | 2.970 μs |    2912 B |
|      LinqAll | .NET 7.0 | .NET 7.0 |  100 | 3.007 μs | 0.0546 μs | 0.0629 μs | 2.985 μs |    2888 B |
| LinqDistinct | .NET 7.0 | .NET 7.0 |  100 | 2.460 μs | 0.0419 μs | 0.0601 μs | 2.446 μs |    1928 B |
|    ToHashSet | .NET 7.0 | .NET 7.0 |  100 | 2.367 μs | 0.0226 μs | 0.0201 μs | 2.358 μs |    1864 B |

Benchmarks with issues:
  Benchmark.Foreach: .NET 6.0(Runtime=.NET 6.0) [Size=100]
  Benchmark.LinqAny: .NET 6.0(Runtime=.NET 6.0) [Size=100]
  Benchmark.LinqAll: .NET 6.0(Runtime=.NET 6.0) [Size=100]
  Benchmark.LinqDistinct: .NET 6.0(Runtime=.NET 6.0) [Size=100]
  Benchmark.ToHashSet: .NET 6.0(Runtime=.NET 6.0) [Size=100]
