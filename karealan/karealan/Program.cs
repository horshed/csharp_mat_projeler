using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karealan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kare ka = new kare();
            Console.Write("Kenar Uzunluğu girin : ");
            int kk = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Karenin Alanı : {0}", ka.alan(kk));          
            Console.ReadKey();
        }
    }
}
