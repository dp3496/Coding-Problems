``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1679 (1909/November2019Update/19H2)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|            Method |     Mean |    Error |   StdDev |   Gen 0 |  Gen 1 | Allocated |
|------------------ |---------:|---------:|---------:|--------:|-------:|----------:|
| TestWithBenchMark | 35.20 μs | 0.600 μs | 0.501 μs | 27.5879 | 0.3662 |    168 KB |
