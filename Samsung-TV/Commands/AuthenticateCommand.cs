using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV.Commands
{
    public class AuthenticateCommand : CommandBase
    {
        private const char START_MESSAGE = (char)0x64;

        public IPAddress SourceIpAddress{ get; private set; }
        public PhysicalAddress MAC { get; private set; }
        public string RemoteName { get; private set; }
        public string AppName { get; private set; }

        public AuthenticateCommand(string remoteName, string appName)
            : this(remoteName, appName, getLocalIPAddress(), GetCurrentMACAddress())
        { }

        public AuthenticateCommand(string remoteName, string appName, IPAddress sourceIP, PhysicalAddress mac)
        {
            this.RemoteName = remoteName;
            this.AppName = appName;
            this.SourceIpAddress = sourceIP;
            this.MAC = mac;
        }

        public override byte[] ToMessage()
        {
            List<byte> result = new List<byte>();
            result.Add(Convert.ToByte(NULL_CHAR));
            result.Add(Convert.ToByte(AppName.Length));
            result.Add(Convert.ToByte(NULL_CHAR));
            result.AddRange(Encoding.ASCII.GetBytes(AppName));

            List<byte> payload = new List<byte>();
            payload.Add(Convert.ToByte(START_MESSAGE));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(SourceIpAddress.ToString()).Length));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(SourceIpAddress.ToString())));
            
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(MAC.ToString()).Length));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(MAC.ToString())));
            
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(RemoteName).Length));
            payload.Add(Convert.ToByte(NULL_CHAR));
            payload.Add(Convert.ToByte(Encoding.ASCII.EncodeBase64(RemoteName)));

            result.Add(Convert.ToByte(payload.Count));
            result.Add(Convert.ToByte(NULL_CHAR));
            result.AddRange(payload);

            return result.ToArray();
        }

        private static IPAddress getLocalIPAddress()
        {
            IPAddress result = null;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    result = ip;
                    break;
                }
            }
            return result;
        }

        private static PhysicalAddress GetCurrentMACAddress()
        {
            PhysicalAddress resultMAC = null;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    resultMAC = nic.GetPhysicalAddress();
                }
            }
            return resultMAC;
        }
    }
}
