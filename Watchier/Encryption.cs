using PWDTK_DOTNET451;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Watchier
{
    static class Encryption
    {

        static public byte[] generateSalt()
        {
            return PWDTK.GetRandomSalt(32); // Creates UTF-8 Byte Array btw, PBKDF2 Key Derivation, length 32
        }

        static public byte[] generateHash(string password, byte[] salt)
        {
            return PWDTK.PasswordToHash(salt, password);
        }

        static public bool checkUserAuth(string password, byte[] hash, byte[] salt)
        {
            return PWDTK.ComparePasswordToHash(salt, password, hash);
        }



        ////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////
        // DEBUG METHODS
        ////////////////////////////////////////////////////////////////////

        static public void printSaltArray(byte[] saltArray)
        {
            for (int i = 0; i < saltArray.Length; i++)
            {
                Console.Write(saltArray[i]);

            }
            Console.WriteLine();
        }



    }
}
