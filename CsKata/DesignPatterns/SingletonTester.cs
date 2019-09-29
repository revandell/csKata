using System;

namespace CsKata.DesignPatterns
{
    class SingletonTester
    {
        // checks if func() returns a singleton
        public static bool IsSingleton(Func<object> func)
        {
            return func() == func();
        }
    }
}
