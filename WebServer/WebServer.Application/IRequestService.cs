using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Application
{
    public interface IRequestService
    {
        Task<RequestDTO> CreateRequest(CreateRequest request);
    }
}
