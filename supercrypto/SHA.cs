using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using HashLib;

namespace supercrypto
{
    class Hasher
    {
        public class megahash
        {
            public megahash(byte[] input)
            {
                SHA1 = generic(input, HashFactory.Crypto.CreateSHA1());
                SHA256 = generic(input, HashFactory.Crypto.CreateSHA256());
                SHA384 = generic(input, HashFactory.Crypto.CreateSHA384());
                SHA512 = generic(input, HashFactory.Crypto.CreateSHA512());
                MD2 = generic(input, HashFactory.Crypto.CreateMD2());
                MD4 = generic(input, HashFactory.Crypto.CreateMD4());
                MD5 = generic(input, HashFactory.Crypto.CreateMD5());
                RIPEMD_128 = generic(input, HashFactory.Crypto.CreateRIPEMD128());
                RIPEMD_160 = generic(input, HashFactory.Crypto.CreateRIPEMD160());
                RIPEMD_256 = generic(input, HashFactory.Crypto.CreateRIPEMD256());
                RIPEMD_320 = generic(input, HashFactory.Crypto.CreateRIPEMD320());
                GOST = generic(input, HashFactory.Crypto.CreateGost());
                WHIRLPOOL = generic(input, HashFactory.Crypto.CreateWhirlpool());
            }
            public string SHA1       { get; }
            public string SHA256     { get; }
            public string SHA384     { get; }
            public string SHA512     { get; }
            public string MD2        { get; }
            public string MD4        { get; }
            public string MD5        { get; }
            public string RIPEMD_128 { get; }
            public string RIPEMD_160 { get; }
            public string RIPEMD_256 { get; }
            public string RIPEMD_320 { get; }
            public string GOST       { get; }
            public string WHIRLPOOL  { get; }
        }

        

        public static DataTable GetTable(megahash m)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Size");
            table.Columns.Add("Hash");
            table.Columns.Add("Result");
            table.Rows.Add(m.SHA1.Length, "SHA1", m.SHA1);
            table.Rows.Add(m.SHA256.Length, "SHA256", m.SHA256);
            table.Rows.Add(m.SHA384.Length, "SHA384", m.SHA384);
            table.Rows.Add(m.SHA512.Length, "SHA512", m.SHA512);
            table.Rows.Add(m.MD2.Length, "MD2", m.MD2);
            table.Rows.Add(m.MD4.Length, "MD4", m.MD4);
            table.Rows.Add(m.MD5.Length, "MD5", m.MD5);
            table.Rows.Add(m.RIPEMD_128.Length, "RIPEMD_128", m.RIPEMD_128);
            table.Rows.Add(m.RIPEMD_160.Length, "RIPEMD_160", m.RIPEMD_160);
            table.Rows.Add(m.RIPEMD_256.Length, "RIPEMD_256", m.RIPEMD_256);
            table.Rows.Add(m.RIPEMD_320.Length, "RIPEMD_320", m.RIPEMD_320);
            table.Rows.Add(m.GOST.Length, "GOST", m.GOST);
            table.Rows.Add(m.WHIRLPOOL.Length, "WHIRLPOOL", m.WHIRLPOOL);
            return table;
        }


        private static string generic(byte[] input, IHash hash)
        {
            HashResult res = hash.ComputeString(Encoding.Default.GetString(input), System.Text.Encoding.ASCII);
            return res.ToString();
        }
    }

    
}
