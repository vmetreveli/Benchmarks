``` ini

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100-preview.7.22377.5
  [Host]   : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX
  .NET 6.0 : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX
  .NET 7.0 : .NET 7.0.0 (7.0.22.37506), X64 RyuJIT AVX


```
|  Method |      Job |  Runtime | Size |        Mean |      Error |       StdDev |      Median | Allocated |
|-------- |--------- |--------- |----- |------------:|-----------:|-------------:|------------:|----------:|
|     Min | .NET 6.0 | .NET 6.0 |  100 |   714.93 ns |  30.448 ns |    86.375 ns |   693.54 ns |      32 B |
|     Max | .NET 6.0 | .NET 6.0 |  100 |   637.35 ns |  14.319 ns |    40.854 ns |   626.72 ns |      32 B |
| Average | .NET 6.0 | .NET 6.0 |  100 |   739.66 ns |  55.337 ns |   153.339 ns |   680.22 ns |      32 B |
|     Sum | .NET 6.0 | .NET 6.0 |  100 |   608.12 ns |  12.022 ns |    12.345 ns |   604.11 ns |      32 B |
| OrderBy | .NET 6.0 | .NET 6.0 |  100 | 4,852.11 ns |  78.533 ns |    69.618 ns | 4,820.91 ns |    1512 B |
|     Min | .NET 7.0 | .NET 7.0 |  100 |    33.20 ns |   0.694 ns |     1.337 ns |    32.82 ns |         - |
|     Max | .NET 7.0 | .NET 7.0 |  100 |    30.52 ns |   0.549 ns |     0.486 ns |    30.45 ns |         - |
| Average | .NET 7.0 | .NET 7.0 |  100 |    39.50 ns |   2.264 ns |     6.083 ns |    37.03 ns |         - |
|     Sum | .NET 7.0 | .NET 7.0 |  100 |    64.71 ns |   0.208 ns |     0.174 ns |    64.71 ns |         - |
| OrderBy | .NET 7.0 | .NET 7.0 |  100 | 6,626.29 ns | 356.947 ns | 1,000.917 ns | 6,329.06 ns |    1512 B |
