using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV.Commands
{
    public abstract class CommandBase : ICommand
    {
        protected const char NULL_CHAR = (char)0x00;

        public abstract byte[] ToMessage();
    }
}
