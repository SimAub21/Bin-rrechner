using System;

namespace Binärrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DezimalToBinary("100011100110"));
            Console.WriteLine(BinaryToDezimal(21));
        }
        static int DezimalToBinary(string binary)
        {
            binary = Reverse(binary);
            double dezimalNumber = default;
            for (int i = 0; i < binary.Length; i++)
            {
                int currentDigit = int.Parse(binary[i].ToString());
                if (currentDigit == 1)
                {
                    dezimalNumber += Math.Pow(2, i);
                }
            }
            return Convert.ToInt32(dezimalNumber);
        }
        static string BinaryToDezimal(int dezimalNumber)
        {
            string binary = default;
            while (dezimalNumber > 0)
            {
                binary += Convert.ToString(dezimalNumber % 2);
                dezimalNumber = dezimalNumber / 2;
            }
            return Reverse(binary);
        }

        /// <summary>
        /// Kehrt die Characters in einem String um
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }

    }
}
