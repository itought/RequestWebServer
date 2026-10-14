using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Application;
using Microsoft.Data.SqlClient;
using Dapper;
using WebServer.Domain;

namespace WebServer.Infrastructure
{
    public class RequestRepository : IRequestRepository
    {
        string? connectionString;

        public RequestRepository(string? _connectionString)
        {
            connectionString = _connectionString;
        }

        public async Task<bool> CreateRequest(Request request)
        {
            try
            {
                using var sql = new SqlConnection(connectionString);

                await sql.OpenAsync();

                return (await sql.ExecuteReaderAsync("INSERT INTO Requests (Id, Title, [Description], Status, CreatedAt, ProcessedBy) VALUES (@Id, @Title, @Desc, @Status, @CreatedAt, @ProcessedBy)",
                    new { Id = request.Id, Title = request.Title, Desc = request.Description, Status = request.Status, CreatedAt = request.CreatedAt, ProcessedBy = request.ProcessedBy })).HasRows;
            }
            catch
            {
                throw;
            }
        }

    }
}
