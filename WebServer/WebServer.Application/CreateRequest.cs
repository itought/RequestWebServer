using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Application
{
    public class CreateRequest
    {
        public string? Title { get; set; }
        public string? Descriprion { get; set; }
        public Guid? ProcessedBy { get; set; }
    }
}
