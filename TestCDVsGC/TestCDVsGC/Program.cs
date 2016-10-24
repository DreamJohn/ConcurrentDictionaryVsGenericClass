using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TestCDVsGC
{
    class Program
    {
        static void Main()
        {
            RunBenchmark();
        }

        private static void RunBenchmark()
        {
            var timings = new List<Tuple<long, long>>();
            const int count = 10000;
            for (var repeat = 0; repeat < 10; repeat++)
            {
                var timing = new Tuple<long, long>(Profile(DoDictionary, count), Profile(DoGeneric, count));
                timings.Add(timing);
                Console.WriteLine($"Run {repeat + 1:00} -> Time1: {timing.Item1}; Time2: {timing.Item2}");
            }

            var avg1 = timings.Average(a => a.Item1);
            var avg2 = timings.Average(a => a.Item2);
            Console.WriteLine($"Avg1: {avg1}; Avg2: {avg2}; Diff[1-2]: {avg1 - avg2}");

            Console.ReadKey();
        }

        public static long Profile(Action<int> a, int count)
        {
            var sw = new Stopwatch();
            sw.Start();

            StartTasks(a, count);

            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        private static void StartTasks(Action<int> a, int count)
        {
            var thLst = new List<Task>();
            for (var i = 0; i < 33; i++)
                thLst.Add(Task.Run(() => a(count)));
            thLst.ForEach(t => t.Wait());
        }

        private static void DoDictionary(int count)
        {
            for (var i = 0; i < count; i++)
            {
                DictionaryClass.Set<TestClass1>();
                DictionaryClass.Set<TestClass2>();
                DictionaryClass.Set<TestClass3>();
                DictionaryClass.Set<TestClass4>();
                DictionaryClass.Set<TestClass5>();
                DictionaryClass.Set<TestClass6>();
                DictionaryClass.Set<TestClass7>();
                DictionaryClass.Set<TestClass8>();
                DictionaryClass.Set<TestClass9>();
                DictionaryClass.Set<TestClass10>();

                DictionaryClass.Set<TestClass11>();
                DictionaryClass.Set<TestClass12>();
                DictionaryClass.Set<TestClass13>();
                DictionaryClass.Set<TestClass14>();
                DictionaryClass.Set<TestClass15>();
                DictionaryClass.Set<TestClass16>();
                DictionaryClass.Set<TestClass17>();
                DictionaryClass.Set<TestClass18>();
                DictionaryClass.Set<TestClass19>();
                DictionaryClass.Set<TestClass20>();

                DictionaryClass.Set<TestClass21>();
                DictionaryClass.Set<TestClass22>();
                DictionaryClass.Set<TestClass23>();
                DictionaryClass.Set<TestClass24>();
                DictionaryClass.Set<TestClass25>();
                DictionaryClass.Set<TestClass26>();
                DictionaryClass.Set<TestClass27>();
                DictionaryClass.Set<TestClass28>();
                DictionaryClass.Set<TestClass29>();
                DictionaryClass.Set<TestClass30>();

                DictionaryClass.Set<TestClass31>();
                DictionaryClass.Set<TestClass32>();
                DictionaryClass.Set<TestClass33>();
                DictionaryClass.Set<TestClass34>();
                DictionaryClass.Set<TestClass35>();
                DictionaryClass.Set<TestClass36>();
                DictionaryClass.Set<TestClass37>();
                DictionaryClass.Set<TestClass38>();
                DictionaryClass.Set<TestClass39>();
                DictionaryClass.Set<TestClass40>();

                DictionaryClass.Set<TestClass41>();
                DictionaryClass.Set<TestClass42>();
                DictionaryClass.Set<TestClass43>();
                DictionaryClass.Set<TestClass44>();
                DictionaryClass.Set<TestClass45>();
                DictionaryClass.Set<TestClass46>();
                DictionaryClass.Set<TestClass47>();
                DictionaryClass.Set<TestClass48>();
                DictionaryClass.Set<TestClass49>();
                DictionaryClass.Set<TestClass50>();

                DictionaryClass.Set<TestClass51>();
                DictionaryClass.Set<TestClass52>();
                DictionaryClass.Set<TestClass53>();
                DictionaryClass.Set<TestClass54>();
                DictionaryClass.Set<TestClass55>();
                DictionaryClass.Set<TestClass56>();
                DictionaryClass.Set<TestClass57>();
                DictionaryClass.Set<TestClass58>();
                DictionaryClass.Set<TestClass59>();
                DictionaryClass.Set<TestClass60>();
            }
        }

        private static void DoGeneric(int count)
        {
            for (var i = 0; i < count; i++)
            {
                GenericClass<TestClass1>.Set();
                GenericClass<TestClass2>.Set();
                GenericClass<TestClass3>.Set();
                GenericClass<TestClass4>.Set();
                GenericClass<TestClass5>.Set();
                GenericClass<TestClass6>.Set();
                GenericClass<TestClass7>.Set();
                GenericClass<TestClass8>.Set();
                GenericClass<TestClass9>.Set();
                GenericClass<TestClass10>.Set();

                GenericClass<TestClass11>.Set();
                GenericClass<TestClass12>.Set();
                GenericClass<TestClass13>.Set();
                GenericClass<TestClass14>.Set();
                GenericClass<TestClass15>.Set();
                GenericClass<TestClass16>.Set();
                GenericClass<TestClass17>.Set();
                GenericClass<TestClass18>.Set();
                GenericClass<TestClass19>.Set();
                GenericClass<TestClass20>.Set();

                GenericClass<TestClass21>.Set();
                GenericClass<TestClass22>.Set();
                GenericClass<TestClass23>.Set();
                GenericClass<TestClass24>.Set();
                GenericClass<TestClass25>.Set();
                GenericClass<TestClass26>.Set();
                GenericClass<TestClass27>.Set();
                GenericClass<TestClass28>.Set();
                GenericClass<TestClass29>.Set();
                GenericClass<TestClass30>.Set();

                GenericClass<TestClass31>.Set();
                GenericClass<TestClass32>.Set();
                GenericClass<TestClass33>.Set();
                GenericClass<TestClass34>.Set();
                GenericClass<TestClass35>.Set();
                GenericClass<TestClass36>.Set();
                GenericClass<TestClass37>.Set();
                GenericClass<TestClass38>.Set();
                GenericClass<TestClass39>.Set();
                GenericClass<TestClass40>.Set();

                GenericClass<TestClass41>.Set();
                GenericClass<TestClass42>.Set();
                GenericClass<TestClass43>.Set();
                GenericClass<TestClass44>.Set();
                GenericClass<TestClass45>.Set();
                GenericClass<TestClass46>.Set();
                GenericClass<TestClass47>.Set();
                GenericClass<TestClass48>.Set();
                GenericClass<TestClass49>.Set();
                GenericClass<TestClass50>.Set();

                GenericClass<TestClass51>.Set();
                GenericClass<TestClass52>.Set();
                GenericClass<TestClass53>.Set();
                GenericClass<TestClass54>.Set();
                GenericClass<TestClass55>.Set();
                GenericClass<TestClass56>.Set();
                GenericClass<TestClass57>.Set();
                GenericClass<TestClass58>.Set();
                GenericClass<TestClass59>.Set();
                GenericClass<TestClass60>.Set();
            }
        }

    }
}
