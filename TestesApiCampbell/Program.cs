using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CampbellApiProject
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            var baseUrl = "http://192.168.66.1/";
            var endpoint = "/?command=DataQuery&mode=most-recent&format=json&uri=dl:OneMin&p1=5"; 

            var response = await GetDataloggerData(baseUrl + endpoint);
            
            var endpoint1 = "/?command=dataquery&uri=dl:OneMin&format=json&mode=date-range&p1=2024-01-08T07:00:00&p2=2024-09-10T11:00:00"; 

            var response1 = await GetDataloggerData(baseUrl + endpoint1);

            var endpointSinceTime = "/?command=dataquery&uri=dl:OneMin&format=json&mode=since-time&p1=2024-09-08T07:00:00";

            var responseSinceTime = await GetDataloggerData(baseUrl + endpointSinceTime);

            var endpointAllTables = "/?command=browsesymbols&uri=dl:&format=json";

            var responseAllTables = await GetDataloggerData(baseUrl + endpointAllTables);

            var endpointSinceRecord = "/?command=dataquery&uri=dl:OneMin&format=html&mode=since-record&p1=500";

            var responseSinceRecord = await GetDataloggerData(baseUrl + endpointSinceRecord);

            Console.WriteLine(response);
        }

        static async Task<string> GetDataloggerData(string url)
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }
    }
}
