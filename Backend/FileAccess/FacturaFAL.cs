using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Backend.Entity;

namespace Backend.FileAccess
{
    public class FacturaFAL
    {
        public int Insertar(Orden orden, string pedido)
        {
            StringBuilder factura = new StringBuilder();
            factura.AppendLine("FACTURA DE RESTAURANTE STEAK INQUEUE");
            factura.AppendLine($"_______________________________________________________________");
            factura.AppendLine($"No. Orden: {orden.numero, -20}Fecha: {DateTime.Now.Date}");
            factura.AppendLine($"Camarero: {orden.camarero, -20}Ubicación: {orden.ubicacion}");
            factura.AppendLine($"_______________________________________________________________");
            factura.AppendLine(pedido);
            factura.AppendLine($"_______________________________________________________________");
            factura.AppendLine($"Total............................................{orden.total}");
            factura.AppendLine($"_______________________________________________________________");

            using (StreamWriter srFile = new StreamWriter($"C:\\DATABASE\\‪FACTURA_{orden.numero}.txt", true))
            {

                srFile.WriteLine(factura);

            }
            return 0;
        }
        public string LeerTodo(string numero)
        {
            if (!File.Exists($"C:\\DATABASE\\‪FACTURA_{numero}.txt"))
                return null;
            string contenido = File.ReadAllText($"C:\\DATABASE\\‪FACTURA_{numero}.txt");
            return contenido;
        

        }
    }
}
