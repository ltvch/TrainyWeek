using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainyCalandar
{
    class Program
    {
        static void Main(string[] args)
        {
              int result = 128;
            // int result = 1;
            //int result = 0x00;
            int input;
            ConsoleKeyInfo key;
            int[] array = new int[6];
            //   do
            //   {
                    Console.WriteLine("Insert number day where you have trainy\n");
                    Console.WriteLine("For see result press SPACE");
                    int.TryParse(Console.ReadLine(), out input);
               
            //       key = Console.ReadKey();
            //   } while (key.Key != ConsoleKey.Spacebar);      
         
            
            input--;//people count from 1, not from 0;
                    //  result >>= input;
                    // result &= ~(1 << input);
            result |= 1 << input;

            Console.WriteLine(int.Parse(Convert.ToString(result, 2)).ToString("0000 0000"));
            Console.WriteLine(result);
            
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
