using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supercrypto
{
    class RSA
    {
        private const int RsaKeySize = 1024;
        public static AsymmetricCipherKeyPair GetKeyPair()
        {
            CryptoApiRandomGenerator randomGenerator = new CryptoApiRandomGenerator();
            SecureRandom secureRandom = new SecureRandom(randomGenerator);
            var keyGenerationParameters = new KeyGenerationParameters(secureRandom, RsaKeySize);

            var keyPairGenerator = new RsaKeyPairGenerator();
            keyPairGenerator.Init(keyGenerationParameters);
            return keyPairGenerator.GenerateKeyPair();
        }
        public static string GetPrivate(AsymmetricCipherKeyPair I)
        {
            TextWriter textWriter = new StringWriter();
            PemWriter pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(I.Private);
            pemWriter.Writer.Flush();

            string privateKey = textWriter.ToString();
            return privateKey;
        }
        public static string GetPublic(AsymmetricCipherKeyPair I)
        {
            TextWriter textWriter = new StringWriter();
            PemWriter pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(I.Public);
            pemWriter.Writer.Flush();

            string publicKey = textWriter.ToString();
            return publicKey;
        }
    }
    public class RSAEncryption
    {
        public static string RsaEncryptWithPublic(string clearText, string publicKey)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(clearText);
            var encryptEngine = new Pkcs1Encoding(new RsaEngine());
            using (var txtreader = new StringReader(publicKey))
            {
                var keyParameter = (AsymmetricKeyParameter)new PemReader(txtreader).ReadObject();
                encryptEngine.Init(true, keyParameter);
            }
            return Convert.ToBase64String(encryptEngine.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length));
        }
        public static string RsaDecryptWithPrivate(string base64Input, string privateKey)
        {
            var bytesToDecrypt = Convert.FromBase64String(base64Input);
            AsymmetricCipherKeyPair keyPair;
            var decryptEngine = new Pkcs1Encoding(new RsaEngine());
            using (var txtreader = new StringReader(privateKey))
            {
                keyPair = (AsymmetricCipherKeyPair)new PemReader(txtreader).ReadObject();
                decryptEngine.Init(false, keyPair.Private);
            }
            return Encoding.UTF8.GetString(decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length));
        }
    }
}
