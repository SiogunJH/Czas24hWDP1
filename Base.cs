using System;
namespace Czas24hWDP1
{
    class Base
    {
        public static void Main()
        {
            // Test 1
            var t = new Czas24h(2, 15, 37);
            t.Minuta = 20;
            t.Godzina = 1;
            t.Sekunda = 26;
            Console.WriteLine(t);

            // Test 4
            t = new Czas24h(2, 15, 37);
            t.Minuta = 20;
            t.Godzina = 23;
            t.Godzina = 1;
            t.Sekunda = 15;
            t.Minuta = 10;
            t.Sekunda = 23;
            t.Sekunda = 1;
            t.Minuta = 12;
            Console.WriteLine(t);
        }
    }
}