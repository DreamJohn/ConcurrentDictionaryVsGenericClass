using System;
using System.Collections.Concurrent;

namespace TestCDVsGC
{
    public static class DictionaryClass
    {
        private static readonly ConcurrentDictionary<Type, Tuple<ITestClass, Random, Random>> _dct = new ConcurrentDictionary<Type, Tuple<ITestClass, Random, Random>>();
        private static readonly ConcurrentDictionary<Type, Random> _dct2 = new ConcurrentDictionary<Type, Random>();
        private static readonly ConcurrentDictionary<Type, Random> _dct3 = new ConcurrentDictionary<Type, Random>();

        public static void Set<T>() where T : ITestClass, new()
        {
            var typeofT = typeof (T);
            var rnd2 = _dct2.GetOrAdd(typeofT, type => new Random(DateTime.Now.Millisecond));
            var rnd3 = _dct3.GetOrAdd(typeofT, type => new Random(DateTime.Now.Millisecond));
            var obj = _dct.GetOrAdd(typeofT, @class => new Tuple<ITestClass, Random, Random>(new T(), rnd2, rnd3));
            obj.Item1.Name = obj.Item2.Next().ToString();
            obj.Item1.Name = obj.Item3.Next().ToString();
        }
    }
}
