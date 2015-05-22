using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Quize
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new MyClass() { Value = 10 };
            var s = new MyStruct() { Value = 10 };
            IInterface ic = new MyClass() { Value = 10 };
            IInterface @is = new MyStruct() { Value = 10 };
            SetValue(c);
            SetValue(s);
            SetValue(ic);
            SetValue(@is);

            WriteLine($"{nameof(c)}:{c.ToString()}");
            WriteLine($"{nameof(s)}:{s.ToString()}");
            WriteLine($"{nameof(ic)}:{ic.ToString()}");
            WriteLine($"{nameof(@is)}:{@is.ToString()}");
        }

        static void SetValue(IInterface target) => target.Value = 100;
        static void SetValue(MyClass target) => target.Value = 100;
        static void SetValue(MyStruct target) => target.Value = 100;

    }

    interface IInterface
    {
        int Value { get; set; }
    }
    class MyClass : IInterface
    {
        public int Value { get; set; }
        public override string ToString() => $"{nameof(Value)}:{Value}";
    }

    struct MyStruct :IInterface
    {
        public int Value { get; set; }
        public override string ToString() => $"{nameof(Value)}:{Value}";
    }

}
