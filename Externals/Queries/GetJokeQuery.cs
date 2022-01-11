using Externals.Queries.Interfaces;
using Models;
using Newtonsoft.Json;

namespace Externals.Queries
{
    public class GetJokeQuery : IGetJokeQuery
    {
        private readonly Context _httpClientContext;

        public GetJokeQuery()
            : this(new Context())
        {

        }
        public GetJokeQuery(Context httpClientContext)
        {
            _httpClientContext = httpClientContext;
        }

        public async Task<Jokes> ExecuteAsync()
        {
            var httpClient = _httpClientContext.GetClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=DEMO_KEY");
            string content = await response.Content.ReadAsStringAsync();

            var jokes = JsonConvert.DeserializeObject<Jokes>(content);

            return jokes;
        }
    }
}
