using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticPolimorfizm polimorfizm = new StaticPolimorfizm();
            polimorfizm.Calculate(100, 300);
            polimorfizm.Calculate(100, 300, true);
            Console.ReadLine();
        }
    }

    public class StaticPolimorfizm
    {
        public void Calculate(double firstParameter, double secondParameter)
        {
            double result = firstParameter + secondParameter;
            Console.WriteLine($"Result of Calculate method without Bool Value - {result}");
        }
        public void Calculate(double firstParameter, double secondParameter, bool value)
        {
            double result = firstParameter + secondParameter + 1000;
            Console.WriteLine($"Result of Calculate method from Bool Value - {result}");
        }
    }
}
