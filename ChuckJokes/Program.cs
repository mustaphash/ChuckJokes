using ChuckJokes.Verbs;
using ChuckJokes.Verbs.Parsers;
using CommandLine;

namespace ChuckJokes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Parser.Default.ParseArguments<JokeVerb>(args)
                .MapResult(
               (JokeVerb opts)=>new JokeParser().JokeParse(opts).GetAwaiter().GetResult(),
               (IEnumerable<Error> errs) => new ExceptionParser().ExceptionHandling(errs).GetAwaiter().GetResult());
        }
    }
}
