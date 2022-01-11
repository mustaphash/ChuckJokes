using CommandLine;

namespace ChuckJokes.Verbs.Parsers
{
    public class ExceptionParser
    {
        public Task<int> ExceptionHandling(IEnumerable<Error> errors)
        {
            Console.WriteLine("Something went wrong.");
            return Task.FromResult(0);
        }
    }
}
