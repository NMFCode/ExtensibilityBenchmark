using System;

namespace NMF.ExtensibilityBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 50; j++)
            {

                var size = int.Parse(args[1]);
                IBenchmarkRunner runner;
                switch (args[0])
                {
                    case "linkedList":
                        runner = new LinkedListBenchmarkRunner(42);
                        break;
                    case "collection":
                        runner = new CollectionBenchmarkRunner(42);
                        break;
                    case "collectionbatch":
                        runner = new CollectionBenchmarkRunnerBatch(42);
                        break;
                    case "linkedListbatch":
                        runner = new LinkedListBenchmarkRunnerBatch(42);
                        break;
                    case "recursiveCollection":
                        runner = new RecursiveCollectionBenchmarkRunner(42);
                        break;
                    default:
                        Console.Error.WriteLine("Unknown implementation");
                        return;
                }

                runner.Generate(size);
                runner.Initialize();
                var results = runner.Run();

                for (int i = 0; i < results.Length; i++)
                {
                    Console.WriteLine($"{args[0]};{size};{i};{results[i].Item1};{results[i].Item2},{Environment.WorkingSet}");
                }
                GC.Collect();
            }
        }
    }
}
