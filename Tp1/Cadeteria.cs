using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class Cadeteria
    {
        string nombre;
        int telefono;
        List<Cadete> cadetes;

        public Cadeteria(string nombre, int telefono, List<Cadete> cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

        
    }
}
