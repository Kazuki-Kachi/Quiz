using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Linq.Enumerable;
namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Question<int>(null);
            Question(Empty<int>());
            Question(Range(0, 1));
        }

        static void Question<T>(IEnumerable<T> values)
        {
            try
            {
                WriteLine(values?.All(_ => false).ToString());
            }
            catch(Exception ex)
            {
                WriteLine($"Type:{ex.GetType().Name}");
                WriteLine($"Message:{ex.Message}");
            }
        }

    }
}
