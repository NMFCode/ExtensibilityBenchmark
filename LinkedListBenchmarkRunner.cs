using NMF.Expressions;
using NMF.ExtensibilityBenchmark.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace NMF.ExtensibilityBenchmark
{
    internal class LinkedListBenchmarkRunner : LinkedListBenchmarkRunnerBatch
    {
        private INotifyValue<double> resultCache;

        public LinkedListBenchmarkRunner(int seed) : base(seed)
        {
        }

        public override double GetResult()
        {
            return resultCache.Value;
        }

        public override void Initialize()
        {
            var computeAverage = Observable.Func(((int, int) tuple) => ((double)tuple.Item1) / tuple.Item2);
            var recurse = Observable.Recurse<IItem, (int, int), (int, int)>((rec, item, tuple) => item == null ? tuple : Add(rec(item.Next, tuple), item.Value));
            resultCache = Observable.Expression(() => computeAverage.Evaluate(recurse.Evaluate(root.Head, ValueTuple.Create(0,0))));
            resultCache.Successors.SetDummy();
        }

        private static (int, int) Add((int, int) before, int value)
        {
            return (before.Item1 + value, before.Item2 + 1);
        }
    }

    internal class LinkedListBenchmarkRunnerBatch : BenchmarkRunner<Item>
    {

        protected readonly Root root = new Root();

        public LinkedListBenchmarkRunnerBatch(int seed) : base(seed)
        {
        }

        public override double GetResult()
        {
            var sum = 0;
            var count = 0;
            var current = root.Head;
            while (current != null)
            {
                sum += current.Value;
                count++;
                current = current.Next;
            }
            return ((double)sum) / count;
        }

        public override void Initialize()
        {
        }

        private static (int, int) Add((int, int) before, int value)
        {
            return (before.Item1 + value, before.Item2 + 1);
        }

        protected override Item AddNewItem(int value)
        {
            var item = new Item { Value = value };
            if (root.Tail == null)
            {
                root.Head = item;
                root.Tail = item;
            }
            else
            {
                root.Tail.Next = item;
                root.Tail = item;
            }
            return item;
        }

        protected override void ChangeValue(Item item, int value)
        {
            item.Value = value;
        }
    }
}
