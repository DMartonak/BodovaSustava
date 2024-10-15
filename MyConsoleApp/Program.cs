using bodovysystem;
using System;

namespace bodovysystem {
    class Program {
        static void Main(string[] args) {
            // Obdlznik
            Bod a = new Bod(0,0);
            Bod b = new Bod(3,0);
            Bod c = new Bod(3,4);
            Bod d = new Bod(0,4);

            Bod p = new Bod(5, 1);

            Obdlznik abcd = new Obdlznik(a, b, c, d);
            Console.WriteLine(abcd.bodLeziVObdlzniku(abcd, p));
        }
    }
}