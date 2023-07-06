``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                   Method |        Mean |       Error |      StdDev | Ratio | RatioSD | Rank |      Gen0 |     Gen1 |   Allocated | Alloc Ratio |
|------------------------- |------------:|------------:|------------:|------:|--------:|-----:|----------:|---------:|------------:|------------:|
|           RunSolution_v2 |    876.9 μs |    16.45 μs |    20.80 μs |  0.01 |    0.00 |    1 |  105.4688 |        - |   647.08 KB |        0.01 |
| RunSolution_3rd_party_v1 | 23,307.9 μs |   462.06 μs |   784.61 μs |  0.35 |    0.02 |    2 | 5937.5000 |        - | 36412.34 KB |        0.65 |
|           RunSolution_v1 | 65,908.5 μs | 1,303.09 μs | 3,122.12 μs |  1.00 |    0.00 |    3 | 9125.0000 | 375.0000 | 55978.99 KB |        1.00 |
