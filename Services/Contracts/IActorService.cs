namespace MyMovieLibrary.Services.Contracts
{
    public interface IActorService
    {
        Task AddActorAsync(string id, string name);
    }
}
