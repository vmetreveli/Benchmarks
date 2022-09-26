using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace FindDuplicates;

[MemoryDiagnoser(false)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
public class Benchmark
{
    private static readonly Random _random = new();
    private static int[]? _collection;

    [Params(10)] public int Size { get; set; }


    [GlobalSetup]
    public void GlobalSetup()
    {
        _collection = Enumerable
            .Range(1, Size)
            .ToArray();

        var index = (int) ( Size * 0.41 );
        _collection[index] = _collection[index + 1];
    }

    [Benchmark]
    public bool Foreach() => ContainsDuplicates.ForEach(_collection);

    [Benchmark]
    public bool LinqAny() => ContainsDuplicates.LinqAny(_collection);

    [Benchmark]
    public bool LinqAll() => ContainsDuplicates.LinqAll(_collection);

    [Benchmark]
    public bool LinqDistinct() => ContainsDuplicates.LinqDistinct(_collection);

    [Benchmark]
    public bool ToHashSet() => ContainsDuplicates.ToHashSet(_collection);
}