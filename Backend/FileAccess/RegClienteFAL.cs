using Backend.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.FileAccess
{
    public class RegClienteFAL
    {
        string myFile;

        public RegClienteFAL(string file)
        {
            myFile = file;
        }

        public string InsertarNuevoCliente(Cliente cliente)
        {
            using (StreamWriter srFile = new StreamWriter(myFile, true))
            {
                srFile.WriteLine($"{cliente.NIT}|{cliente.NombreCliente}|{cliente.Direccion}|{cliente.Telefono}|{cliente.FechaUnion}");
            }

            return "Inserción realizada!!!";
        }
    }
}
