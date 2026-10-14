using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Domain
{
    public class Request
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? ProcessedBy { get; set; }
        public string? Status { get; set; }
    }
}
