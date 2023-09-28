using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class Cliente
    {
        

        string nombre { get; set; }
        string direccion {  get; set; }
        int telefono { get; set; }
        string datosReferenciaDireccion { get; set; }

        public Cliente(string nombre, string direccion, int telefono, string datosReferenciaDireccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.datosReferenciaDireccion = datosReferenciaDireccion;
        }

        public void ListarDatos()
        {
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Teléfono: {0}", telefono);
            
        }

        public void VerDireccion()
        {
            Console.WriteLine("Dirección: ", direccion);
            Console.WriteLine("Datos de Referencia: {0}", datosReferenciaDireccion);
        }
    }
}
