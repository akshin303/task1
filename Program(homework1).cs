using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan proqram
            Console.WriteLine("M deyerini daxil edin");
            var m = Console.ReadLine();
            int M = Convert.ToInt32(m);
            Console.WriteLine("N ededini daxil edin");
            var n = Console.ReadLine();
            int N = Convert.ToInt32(n);
            var count = 0;
            int x = M + 1;
                for(x = M; x<N; x++)
            {
                if(x%21==0)
                {
                    count++;
                }
            }
            Console.WriteLine("bolunen sayi=" + count);
            

        }
    }
}
