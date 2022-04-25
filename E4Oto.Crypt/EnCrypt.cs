using System;
using System.IO;
using System.Security.Cryptography;

namespace E4Oto.Crypt
{
    internal class  EnCrypt
    {
        public static string DoEncrypt(string clearText, string _Pwd)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(_Pwd, Salt._Salt);
            byte[] encryptedData = DoEncrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            string T = Convert.ToBase64String(encryptedData);
            return T;
        }
        private static byte[] DoEncrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = null;
            try
            {
                Rijndael alg = Rijndael.Create();
                alg.Key = Key;
                alg.IV = IV;
                cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(clearData, 0, clearData.Length);
                cs.FlushFinalBlock();
                return ms.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            {
                cs.Close();
            }
        }
    }
}
