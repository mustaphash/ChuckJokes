using Externals.Queries;
using Externals.Queries.Interfaces;

namespace ChuckJokes
{
    public class Program
    {
        static void Main(string[] args)
        {
            IGetJokeQuery jokes = new GetJokeQuery();
            var joke = jokes.ExecuteAsync();
            Console.WriteLine(joke.Result.Created_at);
        }
    }
}
