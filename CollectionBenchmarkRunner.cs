using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.ExtensibilityBenchmark.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMF.ExtensibilityBenchmark
{
    internal class CollectionBenchmarkRunner : CollectionBenchmarkRunnerBatch
    {
        private INotifyValue<double> resultCache;

        public CollectionBenchmarkRunner(int seed) : base(seed)
        {
        }

        public override double GetResult()
        {
            return resultCache.Value;
        }

        public override void Initialize()
        {
            resultCache = Observable.Expression(() => root.Items.Average(i => i.Value));
        }
    }

    internal class RecursiveCollectionBenchmarkRunner : CollectionBenchmarkRunnerBatch
    {
        private INotifyValue<double> resultCache;

        public RecursiveCollectionBenchmarkRunner(int seed) : base(seed)
        {
        }

        public override void Initialize()
        {
            var computeAverage = Observable.Func(((int, int) tuple) => ((double)tuple.Item1) / tuple.Item2);
            var recurse = Observable.Recurse<int, (int, int), (int, int)>((rec, index, tuple) => index >= root.Items.Count ? tuple : Add(rec(index + 1, tuple), root.Items[index].Value));
            resultCache = Observable.Expression(() => computeAverage.Evaluate(recurse.Evaluate(0, ValueTuple.Create(0, 0))));
        }

        private static (int, int) Add((int, int) before, int value)
        {
            return (before.Item1 + value, before.Item2 + 1);
        }

        public override double GetResult()
        {
            return resultCache.Value;
        }


    }

    internal class CollectionBenchmarkRunnerBatch : BenchmarkRunner<Item>
    {
        protected readonly Root root = new Root();

        public CollectionBenchmarkRunnerBatch(int seed) : base(seed)
        {
        }

        public override double GetResult()
        {
            return root.Items.AsEnumerable().Average(i => i.Value);
        }

        public override void Initialize()
        {
        }

        protected override Item AddNewItem(int value)
        {
            var item = new Item { Value = value };
            root.Items.Add(item);
            return item;
        }

        protected override void ChangeValue(Item item, int value)
        {
            item.Value = value;
        }
    }
}
