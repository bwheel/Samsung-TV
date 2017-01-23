using Samsung_TV.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV
{
    public class SamsungTvClient
    {
        public SamsungTvConnection Connection { get; private set; }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
        
        public Task<bool> AuthenticateAsync()
        {
            throw new NotImplementedException();
        }

        public bool SendCommand(ICommand command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendCommandAsync(ICommand command)
        {
            throw new NotImplementedException();
        }
    }
}
