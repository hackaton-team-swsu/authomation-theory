using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agarkov.TheoryOfAuthomats
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var alphabeth = new List<string> { "a", "c", "f", "e", "m", "n", "k" };
                var text = "facamnekfca";

                var a = new AuotoMath(alphabeth, text);

                a.EncodeAlphabet();
                var b = a.EncodeText();

                foreach(var item in b)
                {
                    Console.Write($"{item} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
