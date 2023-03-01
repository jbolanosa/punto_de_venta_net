using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entity
{
    public class Cliente
    {
        public string NIT { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime? FechaUnion { get; set; }

        public Cliente(string NIT, string NombreCliente, string Direccion, int Telefono, DateTime FechaUnion)
        {
            this.NIT = NIT;
            this.NombreCliente = NombreCliente;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.FechaUnion = FechaUnion;
        }
    }
}
