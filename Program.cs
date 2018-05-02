using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dla wartości x zmieniających się w przedziale od 0 do dziesieciu obluczamy funkcję y=3x...

            int x, y;
            Console.WriteLine("Proglam wylicza wartość funkcji y=3x");
            Console.WriteLine("Wartość x zmienia się w przedziale od 0 do 10");
            for (x=0; x<=10; x++)
            {
                y = 3 * x;
                Console.WriteLine("x= "+x + '\t'+" y= "+y);
            }
            Console.WriteLine(" ");

            //Ten sam program wiliczający y = 3x ale tym razem zastosowaniem pentli do...while

            int k=0, j=0;

            Console.WriteLine("Proglam wylicza wartość funkcji j=3k zastosowanie do...while");
            Console.WriteLine("Wartość x zmienia się w przedziale od 0 do 10");
            do
            {
                j = 3 * k;
            
                Console.WriteLine("x= " + k + '\t' + " y= " + j);
                k++;
            } while (k <= 10);



            Console.ReadKey();
        }
    }
}
