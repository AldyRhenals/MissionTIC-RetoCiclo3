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
        public Aviones Create(Aviones newAvion)
        {
            if(aviones.Count > 0)
            {
                newAvion.id = aviones.Max(a => a.id) +1;
            }else{
                newAvion.id = 1;
            }
            aviones.Add(newAvion);
            return newAvion;
        }
        public Aviones Update(Aviones newAvion)
        {
            var avion = aviones.SingleOrDefault(a => a.id == newAvion.id);
            if(avion != null)
            {
                avion.marca                 = newAvion.marca;
                avion.modelo                = newAvion.modelo;
                avion.numero_asientos       = newAvion.numero_asientos;
                avion.numero_banios         = newAvion.numero_banios;
                avion.capacidad_maxima_peso = newAvion.capacidad_maxima_peso;
            }
            return avion;
        }
        public Aviones Delete(int id)
        {
            var avion = aviones.SingleOrDefault(b => b.id == id);
            aviones.Remove(avion);
            return avion;
        }
    }
}
