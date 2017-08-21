using ejercicio_grupo.Modelo;

namespace ejercicio_grupo.Repository
{
    public interface IPersonaRepository
    {
        Persona Create(Persona persona);
        Persona Delete(long id);
        System.Linq.IQueryable<Persona> Get();
        Persona Get(long id);
        void Put(Persona persona);
    }
}