using Samsung_TV.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV
{
    public class SamsungTvClient
    {
        public SamsungTvConnection Connection { get; private set; }

        public SamsungTvClient(IPAddress tvAddress)
        {
            Connection = new SamsungTvConnection(tvAddress);
        }

        public bool Authenticate()
        {
            bool result = false;
            try
            {
                if(ConnectIfNotConnected())
                {
                    ICommand authCommand = new AuthenticateCommand("myName", "myAppName");
                    Connection.SendCommand(authCommand);
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        
        public async Task<bool> AuthenticateAsync()
        {
            bool result = false;
            try
            {
                if (ConnectIfNotConnected())
                {
                    ICommand authCommand = new AuthenticateCommand("myName", "myAppName");
                    await Connection.SendCommandAsync(authCommand);
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool SendCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendCommandAsync(ICommand command)
        {
            throw new NotImplementedException();
        }

        private bool ConnectIfNotConnected()
        {
            bool result = false;
            if(!Connection.IsConnected())
            {
                result = Connection.Connect();
            }
            else
            {
                result = Connection.IsConnected();
            }
            return result;
        }
    }
}
