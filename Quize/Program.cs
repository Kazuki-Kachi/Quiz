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
            object oc = new MyClass() { Value = 10 };
            object os = new MyStruct() { Value = 10 };
            SetValue(c);
            SetValue(s);
            SetValue(ic);
            SetValue(@is);
            SetValue(oc);
            SetValue(os);

            WriteLine($"class:{c.ToString()}");
            WriteLine("-------------------------------");
            WriteLine($"struct:{s.ToString()}");
            WriteLine("-------------------------------");
            WriteLine($"interface(class):{ic.ToString()}");
            WriteLine("-------------------------------");
            WriteLine($"interface(struct):{@is.ToString()}");
            WriteLine("-------------------------------");
            WriteLine($"object(class):{oc.ToString()}");
            WriteLine("-------------------------------");
            WriteLine($"object(struct):{os.ToString()}");
        }
        static void X()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            arr.Add(10);
        }

        static void SetValue(IInterface target) => target.Value = 100;
        static void SetValue(MyClass target) => target.Value = 100;
        static void SetValue(MyStruct target) => target.Value = 100;
        static void SetValue(dynamic target)
        {
            try
            {
                target.Value = 100;
            }
            catch (Exception)
            { }
        }
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
