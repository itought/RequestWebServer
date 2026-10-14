using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Domain;

namespace WebServer.Application
{
    public class RequestService : IRequestService
    {
        IRequestRepository? repository;

        public RequestService(IRequestRepository _repo) => repository = _repo;

        public async Task<RequestDTO> CreateRequest(CreateRequest request)
        {
            try
            {
                var requestEntity = new Request { Title = request.Title, Description = request.Descriprion, Id = Guid.NewGuid(), Status = "new", ProcessedBy = request.ProcessedBy, CreatedAt = DateTimeOffset.Now };

                await repository!.CreateRequest(requestEntity);

                return new RequestDTO
                {
                    Title = requestEntity.Title,
                    Description = requestEntity.Description,
                    Status = requestEntity.Status,
                    CreatedAt = requestEntity.CreatedAt,
                    Id = requestEntity.Id,
                    ProcessedBy = requestEntity.ProcessedBy
                };

            }
            catch
            {
                throw;
            }
        }
    }
}
