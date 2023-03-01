using Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Operations
{
    public class RegistroCliente
    {
        Queue<Cliente> Clientes;
        Cliente RegistrarClientes;

        public RegistroCliente()
        {
            Clientes = new Queue<Cliente>();
        }

        public bool EstaVacia()
        {
            return Clientes.Count == 0;
        }

        public string RegistrarC(Cliente cliente) 
        {
            Clientes.Enqueue(cliente);

            return $"El Cliente fue Registrado Existosamente";
        }

    }
}
