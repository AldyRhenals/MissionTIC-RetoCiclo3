using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
        public RepositorioAviones()
        {
            aviones = new List<Aviones>()
            {
                new Aviones{id = 1, marca = "Airbus", modelo = "A320",        numero_asientos = 150, numero_banios = 3, capacidad_maxima_peso = 75},
                new Aviones{id = 2, marca = "Boeing", modelo = "Boeing 737",  numero_asientos = 168, numero_banios = 4, capacidad_maxima_peso = 67},
                new Aviones{id = 3, marca = "Boeing", modelo = "Boeing 747",  numero_asientos = 660, numero_banios = 9, capacidad_maxima_peso = 390}
            };
        }
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
        public Aviones GetWithId(int id)
        {
            return aviones.SingleOrDefault(a => a.id == id);
        }
    }
}
