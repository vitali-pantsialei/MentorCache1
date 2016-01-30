using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCache
{
    public class CacheIntRedis : ICacheInt
    {
        private static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        public int? Get(int keyNum)
        {
            IDatabase db = redis.GetDatabase();
            return (int?)db.StringGet(keyNum.ToString());
        }

        public void Set(int keyNum, int value)
        {
            IDatabase db = redis.GetDatabase();
            db.StringSet(keyNum.ToString(), value);
        }
    }
}
