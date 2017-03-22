using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public static class CryptoManager
    {
        private static int _keySize = 4096;

        public static void GenerateKeys()
        {
            var csp = new RSACryptoServiceProvider(_keySize);
            
            var privKey = csp.ExportParameters(true);
            
            var pubKey = csp.ExportParameters(false);
            
            string pubKeyString;
            {
                var sw = new System.IO.StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, pubKey);
                pubKeyString = sw.ToString();
            }
            string privateKeyString;
            {
                var sw = new System.IO.StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, privKey);
                privateKeyString = sw.ToString();
            }
            File.WriteAllText("rsa_publickey.xml", pubKeyString);
            File.WriteAllText("rsa_privatekey.xml", privateKeyString);
        }

        public static string Encryption(string text, string publicKey)
        {
            var testData = Encoding.UTF8.GetBytes(text);

            using (var rsa = new RSACryptoServiceProvider(_keySize))
            {
                try
                {                 
                    rsa.FromXmlString(publicKey.ToString());
                    var encryptedData = rsa.Encrypt(testData, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decryption(string text, string privateKey)
        {
            var testData = Encoding.UTF8.GetBytes(text);

            using (var rsa = new RSACryptoServiceProvider(_keySize))
            {
                try
                {
                    var base64Encrypted = text;                 
                    rsa.FromXmlString(privateKey);
                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, correctHash);
        }
    }
}
