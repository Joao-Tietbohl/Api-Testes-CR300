using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestesCampbell
{
    public class ChamadaService
    {
        public readonly string baseUrl = "http://192.168.66.1/";
        public string command = "";
        private static readonly HttpClient client = new HttpClient();

        public ChamadaService()
        {

        }

        public async Task<string> RealizarChamada(string formato, string tipoChamada, string p1, string uri, string p2 = null)
        {
            var endpoint = $"?command=DataQuery&mode={tipoChamada}&format={formato}&uri=dl:{uri}&p1={p1}";

            if (!string.IsNullOrEmpty(p2))
            {
                endpoint = $"{endpoint}&p2={p2}";
            }

            var response = await GetDataloggerData(baseUrl + endpoint);

            if(formato == "json")
            {
                var formattedJson = FormatJson(response);
                return formattedJson;
            }


            return response;
        }

        public string FormatJson(string json)
        {
            var parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
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
