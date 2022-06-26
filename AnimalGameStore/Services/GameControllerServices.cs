using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace AnimalGameStore.Services
{
    public class GameControllerServices : IGameControllerService
    {
        private string? _fossilName;
        public string resultJson = string.Empty;

        public string FindFossilByName(string fossilname, string URL)
        {
            _fossilName = fossilname;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(_fossilName).Result;
                if (response.IsSuccessStatusCode)
                {
                    var fossilRawJson = response.Content.ReadAsStringAsync().Result;
                    resultJson = JToken.Parse(fossilRawJson).ToString(Formatting.Indented);
                    return resultJson;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    return string.Empty;
                }
            }
        }
    }
}
