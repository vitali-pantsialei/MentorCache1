using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciCache
{
    public interface ICacheInt
    {
        int? Get(int keyNum);
        void Set(int keyNum, int value);
    }
}
