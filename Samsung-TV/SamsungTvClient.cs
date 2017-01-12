using Samsung_TV.Commands;
using Samsung_TV.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV
{
    public class SamsungTvClient
    {
        private const int PORT = 55000;
        private TcpClient client;
        private IPAddress ipAddress;
        
        public bool Connected { get; private set; }

        public SamsungTvClient(IPAddress tvAddress)
        {
            ipAddress = tvAddress;
            client = new TcpClient();
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                // Establish a TCP socket connection.
                client.Connect(ipAddress, PORT);
                Connected = result = true;
            }
            catch(Exception)
            {
                // TODO: add logging and spectific exception catching. 
                Connected = result = false;
            }

            return result ;
        }

        public void Disconnect()
        {
            try
            {
                client.Close();
            }
            catch(Exception)
            {
                // TODO: add logging. 
            }
            Connected = false;
        }
        public IResponse SendCommand(ICommand command)
        {
            IResponse result = null;
            try
            {
                // Step 1. get the network connection.
                NetworkStream connection = client.GetStream();

                // Step 2. write the command to the connect. 
                write(connection, command);
                
                // Step 3. read the response from the connection
                List<char> response = read(connection);
                
                // Step 4. Parse the response. 
                result = ResponseParser.Parse(response);
            }
            catch(Exception)
            {
                Connected = false;
                // TODO: add logging. 
            }

            // Return the response to the user. 
            return result;
        }

        private void write(NetworkStream connection, ICommand command)
        {
            StreamWriter writer = new StreamWriter(connection);
            writer.Write(command.ToMessage());
        }

        private List<char> read(NetworkStream connection)
        {
            StreamReader reader = new StreamReader(connection);

            List<char> message = new List<char>();
            
            // Step 1. read in a char which is the length.
            // step 2. read in the payload which is the rest of the body of the packet. 



            return message;
        }
    }
}
