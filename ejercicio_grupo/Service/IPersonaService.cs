using System.Linq;
using ejercicio_grupo.Modelo;

namespace ejercicio_grupo.Service
{
    public interface IPersonaService
    {
        Persona Create(Persona entrada);
        Persona create(Persona entrada);
        Persona Delete(long id);
        IQueryable<Persona> Get();
        Persona Get(long id);
        void Put(Persona entrada);
    }
}