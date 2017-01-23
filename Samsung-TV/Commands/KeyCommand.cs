using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV.Commands
{
    public class KeyCommand : CommandBase
    {
        public string TvName { get; private set; }
        public string Key { get; private set; }

        public KeyCommand(string tvName, string key)
        {
            this.TvName = tvName;
            this.Key = key;
        }


        public override byte[] ToMessage()
        {
            List<byte> result = new List<byte>();

            result.Add(Convert.ToByte(NULL_CHAR));             // 0x00
            result.Add(Convert.ToByte(TvName.Length));         // length of tvname character length.
            result.Add(Convert.ToByte(NULL_CHAR));             // 0x00
            result.AddRange(Encoding.ASCII.GetBytes(TvName));  // tvname EX: iphone.UE32ES6800.iapp.samsung

            List<byte> payload = new List<byte>();
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(Key).Length));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.AddRange(Encoding.ASCII.GetBytes(Encoding.ASCII.EncodeBase64(Key)));

            result.Add(Convert.ToByte(payload.Count));
            result.Add(Convert.ToByte(NULL_CHAR));
            result.AddRange(payload);

            return result.ToArray();
        }
    }
}
