using EFWebApi.Data.Models;
using EFWebApi.Data.Repository;

namespace EFWebApi.Data.Services
{
    public class LibroService : ILibroService
    {
        private readonly ILibroRepository _libroRepository;

        public LibroService(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        
        public void Create(Libro libro)
        {
            _libroRepository.Create(libro);
        }

        public void Delete(int id)
        {
            _libroRepository.Delete(id);
        }

        public List<Libro> GetAll()
        {
            return _libroRepository.GetAll();
        }

        public Libro? GetById(int id)
        {
            return _libroRepository.GetById(id);
        }

        public void Update(Libro libro)
        {
            _libroRepository.Update(libro);
        }
    }
}
