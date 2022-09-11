using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
        public RepositorioRutas()
        {
            rutas = new List<Rutas>()
            {
                new Rutas{id = 1, origen = "El Dorado",     destino = "Los Garzónes",       tiempo_estimado = 30},
                new Rutas{id = 2, origen = "El Dorado",     destino = "La Nubia",           tiempo_estimado = 15},
                new Rutas{id = 3, origen = "Los Garzónes",  destino = "José María Córdova", tiempo_estimado = 30}
            };
        }
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
        public Rutas GetWithId(int id)
        {
            return rutas.SingleOrDefault(a => a.id == id);
        }
    }
}
