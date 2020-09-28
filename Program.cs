using System;

namespace Calisma40_ClassSample
{
    class Program
    {
        static void Main(string[] args)
        { 
            string islem;
            do
            {
                Console.Write(">>İşlemden çıkmak için \"Q/q\" tuşuna, >>>Devam etmek için \"Q/q\" tuşu dışında herhangi bir tuşa basınız :");
                islem=Console.ReadLine();
                
                Emlak emlak = new Emlak();
                emlak.Semti = "Keçiören";
                emlak.Rengi = "Bej";
                emlak.OdaSayisi = 4;
                emlak.KatSayisi = 3;
                emlak.Alani = 140;

                Console.WriteLine("Evin bulunduğu semt :" + emlak.Semti);
                Console.WriteLine("Evin rengi          :" + emlak.Rengi);
                Console.WriteLine("Evin oda sayisi     :" + emlak.OdaSayisi);
                Console.WriteLine("Evin kat sayisi     :" + emlak.KatSayisi);
                Console.WriteLine("Evin alalnı         :" + emlak.Alani + "m2");
                Console.WriteLine();

                emlak.Kaydet("MyText.txt");

                // emlak.Semti = "Yenimahalle";
                // emlak.Rengi = "Sarı";
                // emlak.OdaSayisi = 5;
                // emlak.KatSayisi = 7;
                // emlak.Alani = 240;

                // Console.WriteLine("Evin bulunduğu semt :" + emlak.Semti);
                // Console.WriteLine("Evin rengi          :" + emlak.Rengi);
                // Console.WriteLine("Evin oda sayisi     :" + emlak.OdaSayisi);
                // Console.WriteLine("Evin kat sayisi     :" + emlak.KatSayisi);
                // Console.WriteLine("Evin alalnı         :" + emlak.Alani + "m2");
                // emlak.Kaydet("MyText.txt");
                
            } while (islem.ToLower()!="q");

            Console.Read();
        }
    }
}
