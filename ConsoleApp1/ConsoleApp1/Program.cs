using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caeser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = encrypt("Cheese Please!", 15);          
            Console.WriteLine(Message);
            Console.WriteLine(decrypt(Message, 15));
            Console.ReadKey();
        }

        static string encrypt(string plaintext, int shiftKey)
        {
            string CipherText = "";     
            for (int i = 0; i < plaintext.Length; i++)
            {
                int AsciiCode = (int)plaintext[i];
                if (Char.IsUpper(plaintext[i]))
                {
                    AsciiCode = AsciiCode - 65;
                    AsciiCode = AsciiCode + shiftKey;
                    AsciiCode = AsciiCode + 26;
                    AsciiCode = AsciiCode % 26;
                    AsciiCode = AsciiCode + 65;                    
                }
                else if (Char.IsLower(plaintext[i]))
                {
                    AsciiCode = AsciiCode - 97;
                    AsciiCode = AsciiCode + shiftKey;
                    AsciiCode = AsciiCode + 26;
                    AsciiCode = AsciiCode % 26;
                    AsciiCode = AsciiCode + 97;
                }               
                CipherText = CipherText + (char)AsciiCode;
            }
            return CipherText;
        }

        static string decrypt(string CipherText, int shiftKey)
        {
            string plaintext = "";
            for (int i = 0; i < CipherText.Length; i++)
            {
                int AsciiCode = (int)CipherText[i];
                if (Char.IsUpper(CipherText[i]))
                {
                    AsciiCode = AsciiCode - 65;
                    AsciiCode = AsciiCode - shiftKey;
                    AsciiCode = AsciiCode + 26;
                    AsciiCode = AsciiCode % 26;
                    AsciiCode = AsciiCode + 65;
                }
                else if (Char.IsLower(CipherText[i]))
                {
                    AsciiCode = AsciiCode - 97;
                    AsciiCode = AsciiCode - shiftKey;
                    AsciiCode = AsciiCode + 26;
                    AsciiCode = AsciiCode % 26;
                    AsciiCode = AsciiCode + 97;
                }
                plaintext = plaintext + (char)AsciiCode;
            }
            return plaintext;
        }
         //hello


    }
}
