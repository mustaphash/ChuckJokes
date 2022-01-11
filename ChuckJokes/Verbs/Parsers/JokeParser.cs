using Externals.Queries;
using Externals.Queries.Interfaces;

namespace ChuckJokes.Verbs.Parsers
{
    public class JokeParser
    {
        public async Task<int> JokeParse(JokeVerb verb)
        {
            IGetJokeQuery jokes = new GetJokeQuery();
            var joke = await jokes.ExecuteAsync();

            Console.WriteLine(joke.Id);

            return 0;
        }
    }
}
