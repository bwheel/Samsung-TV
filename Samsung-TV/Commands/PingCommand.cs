using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samsung_TV;

namespace Samsung_TV.Commands
{
    public class PingCommand : ICommand
    {
        private const string APP_STRING = "iphone.iapp.samsung";
        private const string PAYLOAD = "PING";
        public byte[] ToMessage()
        {
            List<byte> result = new List<byte>();
            // header
            result.Add(0x00);
            // header size. 
            result.Add(Convert.ToByte(APP_STRING.Length)); // Check that it's formatted little endian

            // Second byte for the size.
            result.Add(0x00);
            
            // header. 
            result.AddRange(Encoding.ASCII.GetBytes(APP_STRING));

            // Space for payload.
            result.Add(0x00);
            result.Add(0x00);
            result.Add(0x00);

            // Payload size
            string payload = Encoding.ASCII.EncodeBase64( PAYLOAD );
            result.Add( Convert.ToByte( payload.Length ) ); // Check that it's formatted little endian

            // Payload. 
            result.AddRange( Encoding.ASCII.GetBytes( payload ) );

            return result.ToArray();
        }
    }
}
