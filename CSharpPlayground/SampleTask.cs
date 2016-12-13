using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Sample_Code_Test
{
    public static class SampleTask
    {
        public static int TaskTest()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            return t.Result;
        }
    }
}
