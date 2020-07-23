using System;

namespace PKT.LZStringCSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "TEST123456789";

            var component = PKT.LZStringCSharp.LZString.CompressToEncodedURIComponent(test);

            Console.WriteLine($"CompressToEncodedURIComponent：{component}");

            Console.ReadKey();
        }
    }
}
