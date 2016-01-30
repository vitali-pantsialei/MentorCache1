using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCache
{
    public class Fibonacci
    {
        ICacheInt cache;
        public Fibonacci(ICacheInt cache)
        {
            this.cache = cache;
        }

        public int GetNumber(int num)
        {
            int? result = cache.Get(num);
            if (result != null)
                return (int)result;
            else
            {
                if (num == 1)
                {
                    cache.Set(1, 1);
                    return 1;
                }
                else if (num == 2)
                {
                    cache.Set(2, 1);
                    return 1;
                }
                else
                {
                    int res = GetNumber(num - 2) + GetNumber(num - 1);
                    cache.Set(num, res);
                    return res;
                }
            }
        }
    }
}
