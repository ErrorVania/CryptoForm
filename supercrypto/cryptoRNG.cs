using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace supercrypto
{
    class cryptoRNG
    {
        public static byte[] rng(int lenght)
        {
            try
            {
                RNGCryptoServiceProvider rngprov = new RNGCryptoServiceProvider();
                rngprov.Dispose();
                byte[] buffer = new byte[lenght];
                rngprov.GetBytes(buffer);
                return buffer;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
