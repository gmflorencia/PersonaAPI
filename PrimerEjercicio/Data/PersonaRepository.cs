using PrimerEjercicio.Models;
using System.Collections.Generic;

namespace PrimerEjercicio.Data
{
    public class PersonaRepository
    {
        private readonly List<Persona> _repository = new List<Persona>();

        public PersonaRepository()
        {
            // Llenar la lista con algunas tareas de ejemplo en el constructor
            AddPersona(new Persona { Id = 1, Nombre = "Juana", Dni = 37053098, FechaAlta = DateTime.Now }); 
            AddPersona(new Persona { Id = 2, Nombre = "Pedro", Dni = 38460098, FechaAlta = DateTime.Now });
            AddPersona(new Persona { Id = 3, Nombre = "Marta", Dni = 3, FechaAlta = DateTime.Now });
        }

        public IEnumerable<Persona> GetAll()
        {
            return _repository;
        }
       /* public IEnumerable<PersonaRepository> GetAllById()
        {
            return Enumerable.Range(1, 5).Select(index => new Persona
            {
                Id = DateTime.Now.AddDays(index),
                Nombre = Random.Shared.Next(-20, 55),
                Dni = Summaries[Random.Shared.Next(Summaries.Length)]
                FechaAlta =
            })
            .ToArray();
        }*/
        public void AddPersona(Persona persona)
        {
            _repository.Add(persona);
        }
    }
}
