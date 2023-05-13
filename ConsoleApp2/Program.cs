using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public class MyList<T>
        {
            public T Row1 { get; set; }
            public T Row2 { get; set; }
            public MyList<T> List { get; set; } = null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ку");
            var node = new MyList<string>();
        }
    }
}
