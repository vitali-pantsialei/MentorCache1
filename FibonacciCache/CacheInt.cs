using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCache
{
    public class CacheInt : ICacheInt
    {
        private static ObjectCache cache = MemoryCache.Default;

        public int? Get(int keyNum)
        {
            return (int?)cache.Get(keyNum.ToString());
        }

        public void Set(int keyNum, int value)
        {
            cache.Set(keyNum.ToString(), value, ObjectCache.InfiniteAbsoluteExpiration);
        }
    }
}
