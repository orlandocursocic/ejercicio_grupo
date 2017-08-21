using System.Linq;
using ejercicio_grupo.Modelo;

namespace ejercicio_grupo.Service
{
    public interface IPersonaService
    {
        Persona Create(Persona entrada);
        Persona Delete(long id);
        IQueryable<Persona> ReadAll();
        Persona Read(long id);
        void Update(Persona entrada);
    }
}