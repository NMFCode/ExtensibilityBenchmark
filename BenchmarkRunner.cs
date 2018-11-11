using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NMF.ExtensibilityBenchmark
{
    internal interface IBenchmarkRunner
    {
        void Initialize();

        void Generate(int size);

        (double, double)[] Run();
    }

    internal abstract class BenchmarkRunner<T> : IBenchmarkRunner
    {
        private Random random;
        private List<T> items = new List<T>();
        private static Stopwatch stopwatch = new Stopwatch();

        protected BenchmarkRunner(int seed)
        {
            random = new Random(seed);
        }

        protected abstract T AddNewItem(int value);

        protected abstract void ChangeValue(T item, int value);

        public abstract void Initialize();

        public abstract double GetResult();

        public (double, double)[] Run()
        {
            const int changes = 20;
            
            // first one is to get JIT compiler to compile everything
            for (int change = 0; change < changes; change++)
            {
                if (random.NextDouble() < 0.5)
                {
                    items.Add(AddNewItem(random.Next(100)));
                }
                else
                {
                    ChangeValue(items[random.Next(items.Count)], random.Next(100));
                }
            }
            GetResult();

            var result = new(double, double)[20];
            for (int i = 0; i < result.Length; i++)
            {
                var indices = new int[changes];
                var dices = new double[changes];
                var values = new int[changes];
                for (int j = 0; j < values.Length; j++)
                {
                    indices[j] = random.Next(items.Count);
                    dices[j] = random.NextDouble();
                    values[j] = random.Next(100);
                }
                var runResult = 0.0;
                stopwatch.Restart();
                for (int change = 0; change < changes; change++)
                {
                    if (dices[change] < 0.5)
                    {
                        items.Add(AddNewItem(values[change]));
                    }
                    else
                    {
                        ChangeValue(items[indices[change]], values[change]);
                    }
                    runResult += GetResult();
                }
                stopwatch.Stop();

                result[i] = (stopwatch.Elapsed.TotalMilliseconds, runResult);
            }
            return result;
        }

        public void Generate(int size)
        {
            items.Clear();
            for (int i = 0; i < size; i++)
            {
                items.Add(AddNewItem(random.Next(100)));
            }
        }
    }
}
