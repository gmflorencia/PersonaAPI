using PrimerEjercicio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimerEjercicio.Data
{
    public class PersonaRepository
    {
        private readonly List<Persona> _repository = new List<Persona>();
        private int _nextId = 1;


        public PersonaRepository()
        {
            // Llenar la lista con algunas tareas de ejemplo en el constructor
            AddPersona(new Persona { Id = 1, Nombre = "Juana", Dni = 37053098, FechaAlta = DateTime.Now });
            AddPersona(new Persona { Id = 2, Nombre = "Pedro", Dni = 38460098, FechaAlta = DateTime.Now });
            AddPersona(new Persona { Id = 3, Nombre = "Marta", Dni = 31467581, FechaAlta = DateTime.Now });
        }

        public IEnumerable<Persona> GetAll()
        {
            return _repository;
        }
        public void AddPersona(Persona persona)
        {
            persona.Id = _nextId++;
            _repository.Add(persona);
        }
        public void UpdatePersona(Persona persona)
        {
            var existingPersona = _repository.FirstOrDefault(t => t.Id == persona.Id);
            if (existingPersona != null)
            {
                existingPersona.Nombre = persona.Nombre;
                existingPersona.Dni = persona.Dni;
            }
        }
        public void DeletePersona(int id)
        {
            var personaToRemove = _repository.FirstOrDefault(t => t.Id == id);
            if (personaToRemove != null)
            {
                _repository.Remove(personaToRemove);
            }
        }
    }

    }

