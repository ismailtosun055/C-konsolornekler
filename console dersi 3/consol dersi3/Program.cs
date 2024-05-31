using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol_dersi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayilar=0;

            Console.WriteLine("sayi giriniz:");

            sayilar=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("girilen sayi:{0}",sayilar);

            Console.ReadLine();
        }
    }
}
