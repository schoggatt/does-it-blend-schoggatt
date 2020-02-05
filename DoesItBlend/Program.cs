using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var b = new Banana();
            var m = new Mango();
            var s = new Strawberry();
            var c = new IceCubes();

            Console.WriteLine(b.Blend());
            Console.WriteLine(m.Blend());
            Console.WriteLine(s.Blend());

            List<IBlendable> list = new List<IBlendable>() { b, m, s, c};
            foreach(dynamic blend in list)
            {
                Console.WriteLine(blend.Blend());
            }
        }
    }
}
