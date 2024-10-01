using EFWebApi.Data.Models;

namespace EFWebApi.Data.Services
{
    public interface ILibroService
    {
        List<Libro> GetAll();

        void Create(Libro libro);

        void Update(Libro libro);

        Libro? GetById(int id);

        void Delete(int id);
    }
}
