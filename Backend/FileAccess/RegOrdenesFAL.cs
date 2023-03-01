using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entity;
using System.IO;

namespace Backend.FileAccess
{
    public class RegOrdenesFAL
    {
        string direccion;

        public RegOrdenesFAL(string direccion)
        {
            this.direccion = direccion;
        }

        public int Insertar(Orden ordenCompletada)
        {

            try
            {
                using (StreamWriter srFile = new StreamWriter(direccion, true))
                {

                    srFile.WriteLine($"{ordenCompletada.numero}|" +
                        $"{ordenCompletada.camarero}|" +
                        $"{ordenCompletada.ubicacion}|" +
                        $"{ordenCompletada.total}|" +
                        $"{ordenCompletada.estado}|" +
                        $"{ordenCompletada.inicio}|" +
                        $"{ordenCompletada.final}|" +
                        $"{ordenCompletada.tiempoUtilizado}");

                }

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Orden> OrdenesAscendente()
        {
            try
            {
                List<Orden> ordenesPorTiempo = GetOrdenes().OrderBy(tiempo => tiempo.tiempoUtilizado).ToList();

                if (ordenesPorTiempo.Count > 10)
                {
                    int elementosParaEliminar = ordenesPorTiempo.Count - 10;
                    ordenesPorTiempo.RemoveRange(10, elementosParaEliminar);
                }
                return ordenesPorTiempo;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Orden> OrdenesDescendente()
        {
            try
            {
                List<Orden> ordenesPorTiempoDes = GetOrdenes().OrderByDescending(tiempo => tiempo.tiempoUtilizado).ToList();
                if (ordenesPorTiempoDes.Count > 10)
                {
                    int elementosParaEliminar = ordenesPorTiempoDes.Count - 10;
                    ordenesPorTiempoDes.RemoveRange(10, elementosParaEliminar);
                }
                return ordenesPorTiempoDes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Orden> GetOrdenes()
        {
 
            if (!File.Exists(direccion))
            {
                return null;
            }

            try
            {
                List<Orden> ordenes = new List<Orden>();

                using (StreamReader srFile = new StreamReader(direccion))
                {

                    string[] ordenRegistro;

                    string strRegistro = string.Empty;

                    Orden orden;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {

                        //conversion del registro del archivo a arreglo
                        ordenRegistro = strRegistro.Split('|');

                        //asignación de los elementos del arreglo al objeto
                        orden = new Orden(
                            int.Parse(ordenRegistro[0]),
                            ordenRegistro[1],
                            ordenRegistro[2],
                            double.Parse(ordenRegistro[3]),
                            ordenRegistro[4],
                            Convert.ToDateTime(ordenRegistro[5]),
                            Convert.ToDateTime(ordenRegistro[6]),
                            TimeSpan.Parse(ordenRegistro[7])
                            );

                        // agregacion del objeto orden a la lista de ordenes

                        ordenes.Add(orden);
                    }

                }

                return ordenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
