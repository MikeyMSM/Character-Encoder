using System;
using System.Collections.Generic;
class Program
{
    class Encoder
    {
        public static void Problem4()
        {
            // Create a Dictionary list of strings
            Dictionary<char,string> CharacterEncoder = new Dictionary<char, string>()
            {
                {'A', "00001"}, {'B', "00010"}, {'C', "00011"}, {'D', "00100"},
                {'E', "00101"}, {'F', "00110"}, {'G', "00111"}, {'H', "01000"},
                {'I', "01001"}, {'J', "01010"}, {'K', "01011"}, {'L', "01100"},
                {'M', "01101"}, {'N', "01110"}, {'O', "01111"}, {'P', "10000"},
                {'Q', "10001"}, {'R', "10010"}, {'S', "10011"}, {'T', "10100"},
                {'U', "10101"}, {'V', "10110"}, {'W', "10111"}, {'X', "11000"},
                {'Y', "11001"}, {'Z', "11010"}
            };
            
            // input the Character Encodeder 
            Console.WriteLine("Enter the Character Encoder: ");
            string EncodedCharacter = Convert.ToString(Console.ReadLine().ToUpper());
            
            // Adding Space 
            string StringEncoded = "";

            // repeat the loop through the input string and encode each characters
            foreach (char c in EncodedCharacter)
            {
                if (CharacterEncoder.ContainsKey(c))
                {
                    StringEncoded += CharacterEncoder[c] + " ";
                }
                else
                {
                    Console.WriteLine("Invalid Character! Input only letter from A to Z");
                    Environment.Exit(0);
                }
            }
            
            // result of the output 
            Console.WriteLine("Output of StringEncoded is: " + StringEncoded);

        }
        static void Main(string[] args)
        {
            Problem4();
        }
    }
    
}