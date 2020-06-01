using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Helpers
{
    public static class CompressHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var ds = new DeflateStream(mso, CompressionMode.Compress))
                {
                    msi.CopyTo(ds);
                }

                return mso.ToArray();
            }
        }

        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var ds = new DeflateStream(msi, CompressionMode.Decompress))
                {
                    ds.CopyTo(mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
    }
}
