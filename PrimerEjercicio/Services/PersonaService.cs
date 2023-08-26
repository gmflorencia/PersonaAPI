using PrimerEjercicio.Data;
using PrimerEjercicio.Models;

namespace PrimerEjercicio.Services
{
    public class PersonaService
    {
        private readonly PersonaRepository _repository;
        public PersonaService(PersonaRepository Repository)
        {
            _repository = Repository;
        }
        public IEnumerable<Persona> GetAll()
        {
            return _repository.GetAll();
        }
        public void AddPersona(Persona persona)
        {
            _repository.AddPersona(persona);
        }
    }
}
