using System;

namespace TestCDVsGC
{
    public class GenericClass<T> where T : ITestClass, new()
    {
        private static Random _random2 = new Random(DateTime.Now.Millisecond);
        private static Random _random3 = new Random(DateTime.Now.Millisecond);
        private static T _obj = new T();

        public static void Set()
        {
            _obj.Name = _random2.Next().ToString();
            _obj.Name = _random3.Next().ToString();
        }
    }
}
