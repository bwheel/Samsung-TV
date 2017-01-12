using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samsung_TV.Responses
{
    public class ResponseFactory
    {
        public static IResponse GetResponse(ResponseTypes response)
        {
            IResponse result = null;

            switch (response)
            {
                case ResponseTypes.ALLOWED:
                    result = new AllowedResponse();
                    break;
                case ResponseTypes.DENIED:
                    result = new DeniedResponse();
                    break;
                case ResponseTypes.TIMEOUT:
                    result = new TimeoutResponse();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
