using System;
using System.Collections.Generic;
using System.Text;
using static Samsung_TV.CommandTypes;

namespace Samsung_TV
{
    public class MessageBuilder
    {
        private const char NULL_CHAR = (char)0x00;
        private const string APP_STRING = "iphone.iapp.samsung";

        public static char[] GetAuthenticateMessage(string ip, string id, string name)
        {
            List<char> message = new List<char>();

            message.Add(NULL_CHAR);
            message.Add(Convert.ToChar(APP_STRING.Length));
            message.Add(NULL_CHAR);
            message.AddRange(APP_STRING.ToCharArray());

            List<char> payload = new List<char>();
            payload.Add((char)0x64);
            payload.Add(NULL_CHAR);
            payload.AddRange(Encoding.ASCII.EncodeBase64(ip).ToCharArray());
            payload.AddRange(Encoding.ASCII.EncodeBase64(id).ToCharArray());
            payload.AddRange(Encoding.ASCII.EncodeBase64(name).ToCharArray());

            message.Add(Convert.ToChar(payload.Count));
            message.Add(NULL_CHAR);
            message.AddRange(payload);
            
            return message.ToArray();
        }

        public static char[] GetKeyCodeMessage(KeyCode code)
        {
            List<char> message = new List<char>();
            string command = CommandTypes.CommandLookUp[code];

            message.Add(NULL_CHAR);
            message.Add(Convert.ToChar(APP_STRING.Length));
            message.Add(NULL_CHAR);
            message.AddRange(APP_STRING.ToCharArray());

            List<char> payload = new List<char>();
            payload.Add(NULL_CHAR);
            payload.Add(NULL_CHAR);
            payload.Add(NULL_CHAR);
            payload.AddRange(Encoding.ASCII.EncodeBase64(command));

            message.Add(Convert.ToChar(payload.Count));
            message.Add(NULL_CHAR);
            message.AddRange(payload);

            return message.ToArray();
        }
    }
}
