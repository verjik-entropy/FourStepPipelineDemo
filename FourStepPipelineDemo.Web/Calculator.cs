using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourStepPipelineDemo.Web
{
    public class Calculator : ICalculator
    {
        public long Add(int a, int b)
        {
            return (long)a + b;
        }
    }
}
