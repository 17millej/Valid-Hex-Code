using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Hex_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your hexcode: ");
            string input = Console.ReadLine();
            Console.WriteLine(IsValidHexCode(input));
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool IsValidHexCode(string pHexCode)
        {
            if(pHexCode.Length < 7 || pHexCode.Length > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return false;
            }
                            
            if (pHexCode[0] != '#')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return false;
            }

            for(int i = 1; i < pHexCode.Length; i++)
            {
                if (IsValidChar(pHexCode[i]) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            return true;
        }

        static bool IsValidChar(char pChar)
        {
            pChar = char.ToUpper(pChar);
            char[] validChars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for(int i = 0; i < validChars.Length; i++)
            {
                if (validChars[i] == pChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
