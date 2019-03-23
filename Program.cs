using System;
using System.Diagnostics;

namespace TrainyCalandar
{
    internal class Program
    {
        ///<summary>
        /// Set value for specific bit in byte
        ///</summary>
        ///<param name="value">Inserted byte</param>
        ///<param name="number">Number byte</param>
        ///<param name="bit"> true set to 1, false set to 0 </param>
        ///<returns>Changed byte/returns>
        public static byte SetBit(byte value, int number, bool bit)
        {
            // if (IsValidNumber(number){

            if ((number > 7) || (number < 0))//check inserted number
            {
                //  throw new ArgumentException();
                Debug.WriteLine("No valid number parameter");
            }

            byte ins = 1;
            ins = (byte)(ins << number);//set concrete bit in 1
            value = (byte)(value & (~ins));//set concrete bit in 0

            if (bit)// if bit in 1
            {
                value = (byte)(value | (ins));//set to 1
            }
            return value;
            //}
            //return byte.MinValue;
        }

        ///<summary>
        /// Reverse bit in byte
        ///</summary>
        ///<param name="value">Inserted byte</param>
        ///<returns>byte with reverse order byte</returns>
        public static byte Reverse(byte value)
        {
            int i = 0;
            byte result = 0;

            for (i = 0; i <= 7; i++)
            {
                result = (byte)(result << 1);//
                if (((value >> i) & 1) > 0)
                {
                    result = (byte)(result | 1);
                }
            }
            return result;
        }


        /// <summary>
        /// Checked range of number (0..7) 
        /// </summary>
        /// <param name="number">Checked Number</param>
        /// <returns>bool result as valid or unvalid number</returns>
        /// <remarks>Bit in bite counted from 0 to 7</remarks>
        private static bool IsValidNumber(int number)
        {
            if ((number > 7) || (number < 0))//check inserted number
            {
                //  throw new ArgumentException();
                Debug.WriteLine("No valid number parameter");
            }
            return true;
        }

        private static void Main(string[] args)
        {
            // byte result = 128;
            // int result = 1;
            // int result = 0;
            byte result = 0x00;
            // byte result = 0x80;
            int input;
            ConsoleKeyInfo key;
            int[] array = new int[6];
            //   do
            //   {
            Console.WriteLine("Insert number day where you have training\n");
           // Console.WriteLine("For see result press SPACE");
            Console.WriteLine(int.Parse(Convert.ToString(result, 2)).ToString("0000 0000"));
            int.TryParse(Console.ReadLine(), out input);

            //       key = Console.ReadKey();
            //   } while (key.Key != ConsoleKey.Spacebar);      


            // input--;//people count from 1, not from 0;
            //      result >>= input;
            // result &= ~(1 << input);
            // result = 1<< input;
            

            result = SetBit(result, input, true);
            result = Reverse(result);

            Console.WriteLine(int.Parse(Convert.ToString(result, 2)).ToString("0000 0000"));
            Console.WriteLine(result);

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
