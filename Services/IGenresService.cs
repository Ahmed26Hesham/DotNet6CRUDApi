namespace MoviesApi.Services
{
    public interface IGenresService
    {
        Task<IEnumerable<Genre>> GetAll();
        Task<Genre> GetById(byte id);
        Task<Genre> Add(Genre Genre);
        Genre Update(Genre Genre);
        Genre Delete(Genre Genre);
        Task<bool> IsValidGenre(byte id);
    }
}
