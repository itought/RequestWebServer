using System.Net.Http.Json;
using WebServer.Application;

HttpClient client = new HttpClient() { BaseAddress = new Uri("http://localhost:7224/api/requests/") };

var response = await client.PostAsJsonAsync("create-request", new CreateRequest { Title = "Docker test", Descriprion = "Пытаюсь создать контейнер, день 12351" });


Console.WriteLine($"{await response.Content.ReadAsStringAsync()}");
