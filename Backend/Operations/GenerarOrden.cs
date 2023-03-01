using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entity;
using Backend.FileAccess;

namespace Backend.Operations
{
    public class GenerarOrden
    {
        Queue<Orden> Ordenes;
        Orden ordenCompletada;

        public GenerarOrden()
        {
            Ordenes = new Queue<Orden>();
        }

        public bool EstaVacia()
        {
            return Ordenes.Count == 0;
        }
        public bool EstaLlena()
        {
            return Ordenes.Count == 10;
        }

        public string AgregarOrden(Orden orden)
        {
            if (EstaLlena())
                return "El maximo de ordenes en cola fue alcanzado";

            Ordenes.Enqueue(orden);

            return $"La orden {orden.numero} fue agregada con exito a la cola!!!";
        }
        public int Refrescar()
        {
            if (EstaVacia())
                return -1;
            ordenCompletada = Ordenes.Peek();
            return ordenCompletada.numero;
        }
        public string IniciarOrden()
        {
            ordenCompletada = Ordenes.Peek();
            ordenCompletada.inicio = DateTime.Now;
            return $"La orden {ordenCompletada.numero} fue iniciada con exito!!!";
        }
        public Orden CompletarOrden()
        {
            Ordenes.Dequeue();

            ordenCompletada.estado = "COMPLETADA";
            ordenCompletada.final = DateTime.Now;
            ordenCompletada.tiempoUtilizado = ordenCompletada.final - ordenCompletada.inicio;
            return ordenCompletada;

        }
    }
}
