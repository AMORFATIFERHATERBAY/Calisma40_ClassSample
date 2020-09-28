using System;

namespace Calisma40_ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlak emlak = new Emlak();
            emlak.Semti = "Keçiören";
            emlak.Rengi = "Bej";
            emlak.OdaSayisi = 4;
            emlak.KatSayisi = 3;
            emlak.Alani = 140;

            Console.WriteLine("Evin bulunduğu semt :"+emlak.Semti);
            Console.WriteLine("Evin rengi          :"+emlak.Rengi);
            Console.WriteLine("Evin oda sayisi     :"+emlak.OdaSayisi);
            Console.WriteLine("Evin kat sayisi     :"+emlak.KatSayisi);
            Console.WriteLine("Evin alalnı         :"+emlak.Alani+"m2");

            Console.Read();
        }
    }
}
