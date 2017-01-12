using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV
{
    public static class Utility
    {
        /// <summary>
        /// Helper function to encode string into base 64.
        /// </summary>
        /// <param name="encoding">The input encoding of text</param>
        /// <param name="text">The payload to encode.</param>
        /// <returns></returns>
        public static string EncodeBase64(this Encoding encoding, string text)
        {
            
            if (text == null)
            {
                return null;
            }

            byte[] textAsBytes = encoding.GetBytes(text);
            return Convert.ToBase64String(textAsBytes);
        }

        /// <summary>
        /// Helper function to decode base64 into text.
        /// </summary>
        /// <param name="encoding">The output encoding of the result</param>
        /// <param name="encodedText">The payload to decode.</param>
        /// <returns></returns>
        public static string DecodeBase64(this Encoding encoding, string encodedText)
        {
            if (encodedText == null)
            {
                return null;
            }

            byte[] textAsBytes = Convert.FromBase64String(encodedText);
            return encoding.GetString(textAsBytes);
        }

    }
}
