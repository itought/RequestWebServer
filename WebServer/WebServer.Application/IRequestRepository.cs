using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Domain;


namespace WebServer.Application
{
    public interface IRequestRepository
    {
        Task<bool> CreateRequest(Request entity);
    }
}
