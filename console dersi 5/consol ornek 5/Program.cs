using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol_ornek_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam=0, toplam1 = 0, n,i;
            Console.Write("gireceginiz degere gore çift ve tek  sayilar ayrı ayrı toplanacak:");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                }
                else
                {
                    toplam1 = toplam1 + i;
                }
                
            }
            Console.WriteLine("çift sayilarin toplami:"+toplam);
            Console.Write("tek sayilarin toplami:" + toplam1);
            Console.Read();
        }
    }
}
