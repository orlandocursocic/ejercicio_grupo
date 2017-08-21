using System.Linq;
using ejercicio_grupo.Modelo;

namespace ejercicio_grupo.Repository
{
    public interface IPersonaRepository
    {
        Persona Create(Persona persona);
        Persona Delete(long id);
        IQueryable<Persona> Get();
        Persona Get(long id);
        void Put(Persona persona);
    }
}