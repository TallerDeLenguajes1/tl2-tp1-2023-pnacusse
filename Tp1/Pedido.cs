using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    public class Pedido
    {
        int nro {  get; set; }
        string obs { get; set; }
        string estado { get; set; }
        Cliente cliente { get; set; }

        public Pedido(int nro, string obs, string estado, Cliente cliente)
        {
            this.nro = nro;
            this.obs = obs;
            this.estado = estado;
            this.cliente = cliente;
        }

        public void VerDireccionCliente()
        {
            this.Cliente.VerDireccion();
        }

        public void VerDatosCliente()
        {
            this.Cliente.ListarDatos();
        }
    }
}
