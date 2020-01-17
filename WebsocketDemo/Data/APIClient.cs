using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebsocketDemo.Data
{
    public class APIClient
    {
        HttpClient client = new HttpClient();
        public async Task<List<Juna>> GetJunaAsync()
        {
            var parser = new Parser();
            client.BaseAddress = new Uri("https://rata.digitraffic.fi/api/v1/");
            var response = await client.GetAsync("train-locations/latest");
            string result = response.Content.ReadAsStringAsync().Result;
            var data = parser.ParseJson(result);

            return data;
        }
    }
}
