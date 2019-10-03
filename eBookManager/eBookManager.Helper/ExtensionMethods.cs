using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookManager.Helper
{
    public static class ExtensionMethods
    {
        public static double ToMegabytes(this long bytes)
        {
            return (bytes > 0) ? (bytes / 1024f) / 1024f : bytes;
        }

        public static int ToInt(this string value, int defaultInteger = 0)
        {
            try
            {
                if (int.TryParse(value, out int validInteger))
                    // Out variables
                    return validInteger;
                else
                    return defaultInteger;
            }
            catch
            {
                return defaultInteger;
            }
        }
    }
}
