using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram
            Console.WriteLine("ayin ededini daxil edin");
            var ay = Console.ReadLine();
            var ayy = Convert.ToInt32(ay);
            if (ayy < 13 && ayy > 0)
            {
                if (ayy == 12 || ayy < 3)
                {
                    Console.WriteLine("fesil qish");
                }
                else if (ayy == 3 || ayy < 6)
                {
                    Console.WriteLine("fesil yaz");
                }
                else if (ayy == 6 || ayy < 9)
                {
                    Console.WriteLine("fesil yay");
                }
                else
                    Console.WriteLine("payiz");



            }
            else
                Console.WriteLine("ededi duzgun daxil edin");
            
                      

            
                

          

            
        }
    }
}
