``` ini

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]   : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX
  .NET 6.0 : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX
  .NET 7.0 : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX


```
|       Method |      Job |  Runtime | Size |     Mean |    Error |   StdDev |   Median | Allocated |
|------------- |--------- |--------- |----- |---------:|---------:|---------:|---------:|----------:|
|      Foreach | .NET 6.0 | .NET 6.0 |   10 | 186.7 ns |  3.77 ns |  9.24 ns | 184.6 ns |     368 B |
|      LinqAny | .NET 6.0 | .NET 6.0 |   10 | 215.2 ns |  4.29 ns |  7.41 ns | 216.0 ns |     456 B |
|      LinqAll | .NET 6.0 | .NET 6.0 |   10 | 207.8 ns |  4.19 ns |  8.47 ns | 207.1 ns |     432 B |
| LinqDistinct | .NET 6.0 | .NET 6.0 |   10 | 256.5 ns |  5.05 ns |  5.61 ns | 257.8 ns |     392 B |
|    ToHashSet | .NET 6.0 | .NET 6.0 |   10 | 226.1 ns |  4.54 ns | 11.96 ns | 223.7 ns |     328 B |
|      Foreach | .NET 7.0 | .NET 7.0 |   10 | 363.8 ns |  7.02 ns |  9.12 ns | 360.0 ns |     368 B |
|      LinqAny | .NET 7.0 | .NET 7.0 |   10 | 500.0 ns | 10.05 ns | 25.20 ns | 492.0 ns |     456 B |
|      LinqAll | .NET 7.0 | .NET 7.0 |   10 | 466.3 ns |  9.21 ns | 13.50 ns | 463.9 ns |     432 B |
| LinqDistinct | .NET 7.0 | .NET 7.0 |   10 | 441.8 ns |  7.82 ns | 11.71 ns | 437.9 ns |     392 B |
|    ToHashSet | .NET 7.0 | .NET 7.0 |   10 | 407.7 ns |  8.14 ns | 12.18 ns | 407.9 ns |     328 B |
