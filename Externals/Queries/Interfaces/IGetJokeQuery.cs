using Models;

namespace Externals.Queries.Interfaces
{
    public interface IGetJokeQuery
    {
        Task<Jokes> ExecuteAsync();
    }
}
