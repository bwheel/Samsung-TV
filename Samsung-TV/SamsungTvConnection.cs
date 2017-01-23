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
    // TODO: consider using IDisposable. 
    public class SamsungTvConnection 
    {
        private const int PORT = 55000;
        // TODO: convert these into tv responses classes. 
        private char[] ALLOWED = { (char)0x64, (char)0x00, (char)0x01, (char)0x00 }; // TV return payload.
        private char[] DENIED = { (char)0x64, (char)0x00, (char)0x00, (char)0x00 };
        private char[] TIMEOUT = { (char)0x65, (char)0x00 };

        private TcpClient client;


        public IPAddress Address { get; private set; }
        public bool Connected { get; private set; }

        public SamsungTvConnection(IPAddress tvAddress)
        {
            Address = tvAddress;
            client = new TcpClient();
        }
        
        /// <summary>
        /// This function returns the connection status of the tv connection. 
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            return client != null &&
                   client.Connected &&
                   this.Connected;
        }

        /// <summary>
        /// This function establishes a connection to the TV.
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            bool result = false;
            try
            {
                // reinitialize the client if previously disconnected. 
                if (client == null)
                {
                    client = new TcpClient();
                }
                // attempt to connect.
                client.Connect(Address, PORT);
                // record the result.
                result = Connected = client.Connected;
            }
            catch (Exception)
            {
                // TODO: add logging. 
                result = false;
            }
            return result;
        }

        /// <summary>
        /// This function disconnects with the TV.
        /// </summary>
        public void Disconect()
        {
            try
            {
                if (client.Connected)
                {
                    client.Close();
                }
            }
            catch (Exception)
            {
                // TODO: add logging. 

            }
            finally
            {
                client = null;
                Connected = false;
            }
        }

        /// <summary>
        /// This function sends a command to the TV on the connect. 
        /// Requires that an connection be open first. 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public IResponse SendCommand(ICommand command)
        {
            IResponse result = null;
            try
            {
                if(Connected)
                {
                    BinaryWriter writer = new BinaryWriter(client.GetStream());
                    writer.Write(command.ToMessage());

                    BinaryReader reader = new BinaryReader(client.GetStream());
                    List<byte> response = new List<byte>();

                    byte[] buffer = new byte[128];
                    int bytesRead = 0;
                    // keep looping while we have read bytes. // TODO: Test this.
                    while ((bytesRead = reader.Read(buffer, 0, 128)) != 0)
                    {
                        // keep track of the bytes. 
                        response.AddRange(buffer);

                        buffer = new byte[128]; // clear the buffer.
                    }
                    
                    // Decode the response into an object.
                    ResponseDecoder decoder = new ResponseDecoder();
                    result = decoder.Decode(response.ToArray());
                }
            }
            catch (Exception)
            {
                // TODO: add logging. 
                result = null;
            }
            return result;
        }

        public async Task<IResponse> SendCommandAsync(ICommand command)
        {
            return await Task.Run<IResponse>( () => 
                {
                    return SendCommand(command);
                }
            );
        }
        

        /*
        private bool connect()
        {
            bool result = false;

            try
            {
                client.Connect(Address, PORT);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private AuthenticationState Authenticate()
        {
            AuthenticationState result = AuthenticationState.DENIED;
            try
            {
                char[] authMessage = MessageBuilder.GetAuthenticateMessage(Address.ToString(), Id, Name);

                NetworkStream connection = client.GetStream();

                StreamWriter writer = new StreamWriter(connection);
                writer.Write(authMessage);

                StreamReader reader = new StreamReader(connection);
                int length = reader.Read();
                char[] response = new char[length];
                reader.Read(response, 0, length);

                if(response.MatchesArray(ALLOWED))
                {
                    result = AuthenticationState.AUTHENTICATED;
                }
                else if(response.MatchesArray(DENIED))
                {
                    result = AuthenticationState.DENIED;
                }
                else if(response.MatchesArray(TIMEOUT))
                {
                    result = AuthenticationState.TIMEOUT;
                }

            }
            catch(Exception)
            {
                throw new IOException();
            }

            return result;
        }

        private List<char> read(NetworkStream connection)
        {
            StreamReader reader = new StreamReader(connection);

            List<char> message = new List<char>();

            // Step 1. read in a char which is the length.
            // step 2. read in the payload which is the rest of the body of the packet. 
            return message;


        }
        */
    }
}
