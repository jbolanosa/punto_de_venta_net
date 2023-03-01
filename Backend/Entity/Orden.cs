using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entity
{
    public class Orden
    {
        public int numero { get; set; }
        public string camarero { get; set; }
        public string ubicacion { get; set; }
        public double total { get; set; }
        public string estado { get; set; }
        public DateTime? inicio { get; set; }
        public DateTime? final { get; set; }
        public TimeSpan? tiempoUtilizado { get; set; }

        public Orden(int numero, string camarero, string ubicacion, double total, string estado, DateTime? inicio, DateTime? final, TimeSpan? tiempoUtilizado)
        {
            this.numero = numero;
            this.camarero = camarero;
            this.ubicacion = ubicacion;
            this.total = total;
            this.estado = estado;
            this.inicio = inicio;
            this.final = final;
            this.tiempoUtilizado = tiempoUtilizado;
        }
    }
}
