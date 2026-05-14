using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    internal class Program
    {
        static string BitArrayToString(System.Collections.BitArray bitArray)
        {
            char[] chars = new char[bitArray.Length];
            for(int i = 0; i < bitArray.Length; i++)
            {
                chars[i] = bitArray[i] ? '1' : '0';
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            System.Collections.BitArray bits1 = new System.Collections.BitArray(10);
            Console.WriteLine("\nbits1 content: " + BitArrayToString(bits1));
            for(int i = 0; i < bits1.Count; i++)
            {
                bool bitVal = bits1[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            bool[] initialValues = { true, false, true, true, false };
            System.Collections.BitArray bits2 = new System.Collections.BitArray(initialValues);
            Console.WriteLine("\nbits2 content: " + BitArrayToString(bits2));
            for (int i = 0; i < bits2.Count; i++)
            {
                bool bitVal = bits1[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            byte[] byteArray = { 0xAA, 0x55 }; // 10101010, 01010101
            System.Collections.BitArray bits3 = new System.Collections.BitArray(byteArray);

            Console.WriteLine("\nbits3 content: " + BitArrayToString(bits3));
            for (int i = 0; i < bits3.Count; i++)
            {
                bool bitVal = bits3[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            // Basic Operations
            System.Collections.BitArray bits4 = new System.Collections.BitArray(8); // 00000000
            bits4.Set(2, true);
            bits4.Set(5, true);
            bits4[7] = true;
            bits4[3] = false;
            bits4.SetAll(true);
            Console.WriteLine("\nbits4 content after setting all to true: " + BitArrayToString(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            bits4.SetAll(false);
            Console.WriteLine("\nbits4 content after setting all to false: " + BitArrayToString(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bitVal = bits4[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            bool bitValue = bits4[3];
            int length = bits4.Length;
            System.Collections.BitArray bits5 = new System.Collections.BitArray(8);
            bits5.SetAll(true);
            Console.WriteLine("\nbits5 content after setting all to true: " + BitArrayToString(bits5));
            for (int i = 0; i < bits5.Count; i++)
            {
                bool bitVal = bits5[i];
                Console.WriteLine($"Bit at index {i}: {bitVal}");
            }
            // Create two BitArrays
            System.Collections.BitArray bits6 = new System.Collections.BitArray(new bool[] { true, false, true, false });
            System.Collections.BitArray bits7 = new System.Collections.BitArray(new bool[] { true, true, true, false });


            Console.WriteLine("bits6 : " + BitArrayToString(bits6));
            Console.WriteLine("bits7 : " + BitArrayToString(bits7));
            Console.WriteLine("BitWise Operators:");
            System.Collections.BitArray resultAnd = new System.Collections.BitArray(bits6);
            resultAnd.And(bits7);
            Console.WriteLine("\nBitwise AND result: ");
            Console.WriteLine(BitArrayToString(bits6));
            Console.WriteLine(BitArrayToString(bits7));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultAnd));
            // Bitwise Or operation

            System.Collections.BitArray resultOr = new System.Collections.BitArray(bits6);
            resultOr.Or(bits7);
            Console.WriteLine("\nBitwise Or result: ");
            Console.WriteLine(BitArrayToString(bits6));
            Console.WriteLine(BitArrayToString(bits7));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultOr));
            System.Collections.BitArray resultNot = new System.Collections.BitArray(bits6);
            resultNot.Not();

            Console.WriteLine("\nBitwise Not result: ");
            Console.WriteLine(BitArrayToString(bits6));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultNot));

            // Bitwise Xor operation
            /*
             Explaining the XOR:
             XOR Table: returns true of the two bits are diffrent, otherwise returns false.

                | A | B | A XOR B |
                |---|---|---------|
                | 0 | 0 |    0    |
                | 0 | 1 |    1    |
                | 1 | 0 |    1    |
                | 1 | 1 |    0    |
             */
            System.Collections.BitArray resultXor = new System.Collections.BitArray(bits6);
            resultXor.Xor(bits7);


            Console.WriteLine("\nBitwise Xor result: ");
            Console.WriteLine(BitArrayToString(bits6));
            Console.WriteLine(BitArrayToString(bits7));
            Console.WriteLine("------------");
            Console.WriteLine(BitArrayToString(resultXor));

        }
    }
}
