using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ra.Database
{
    internal static class Base64Compress
    {
        public static string Encode(string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);

            using var ms = new MemoryStream();
            using (var gzip = new GZipStream(ms, CompressionMode.Compress))
            {
                gzip.Write(bytes, 0, bytes.Length);
            }

            return Convert.ToBase64String(ms.ToArray());
        }
        public static string Decode(string encoded)
        {
            var compressed = Convert.FromBase64String(encoded);

            using var ms = new MemoryStream(compressed);
            using var gzip = new GZipStream(ms, CompressionMode.Decompress);
            using var outMs = new MemoryStream();

            gzip.CopyTo(outMs);

            return Encoding.UTF8.GetString(outMs.ToArray());
        }
    }
}
