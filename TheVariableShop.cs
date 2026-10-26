using System.Reflection.PortableExecutable;

namespace Challenges
{
    internal static class TheVariableShop
    {
        public static void Run(string[] args)
        {
            byte a = 56;
            Console.WriteLine(a);


            short b = -32;
            Console.WriteLine(b);

            short c= 32;
            Console.WriteLine(c);

            int d = -2;
            Console.WriteLine(d);

            int f = 2;
            Console.WriteLine(f);

            long g = -36745903;
            Console.WriteLine(g);

            long h = 36745903;
            Console.WriteLine(h);

            sbyte i = -128;
            Console.WriteLine(i);

            sbyte j = 127;
            Console.WriteLine(j);

            ushort k = 65000;
            Console.WriteLine(k);

            uint l = 4123446;
            Console.WriteLine(l);

            ulong m = 1728327384759;
            Console.WriteLine(m);

            Char n = 'J';
            Console.WriteLine(n);

            string o = "Hola la bola";
            Console.WriteLine(o);

            bool p = true;
            Console.WriteLine(p);

            float q = 3.456f;
            Console.WriteLine(q );

            double r = 3.456;
            Console.WriteLine(r );

            decimal s = 3.647m;
            Console.WriteLine(s);

            a = 4;
            b = 4;
            c = 4;
            d = 4;
            f = 4;
            g = 4;
            h = 4;
            n = '4';
            o  = "4";
            p = false;
            q = 4.0f;
            r = 4.0;
            s = 4.0m;

            
        }
    }
}