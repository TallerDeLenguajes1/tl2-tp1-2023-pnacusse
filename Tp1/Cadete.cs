using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class Cadete
    {
        int id;
        string nombre;
        string direccion;
        int telefono;
        List<Pedido> pedidos;

        public Cadete(int id, string nombre, string direccion, int telefono, List<Pedido> pedidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.pedidos = pedidos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public int JornalACobrar()
        {
            //agregar formula para cobrar
            return 0;
        }
    }
}
