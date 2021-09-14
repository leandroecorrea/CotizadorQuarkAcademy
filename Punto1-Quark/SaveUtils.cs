using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Punto1_Quark
{
    public static class SaveUtils
    {

        private static string filePath = "data" + Path.DirectorySeparatorChar + "cotizaciones.json";
        private static string indexesPath = "data" + Path.DirectorySeparatorChar + "indexes.json";

        public static void SaveCotizacion(Cotizacion cotizacion)
        {
            string registro = JsonSerializer.Serialize(cotizacion) + "\n";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, registro);
            }
            else
            {
                Directory.CreateDirectory("data");
                File.Create(filePath);
                while (UnvailableFile(registro)) ;
            }
        }
        public static List<Cotizacion> LoadCotizaciones()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    List<Cotizacion> cotizacionesGuardadas = new List<Cotizacion>(); ;
                    foreach (string registro in File.ReadLines(filePath))
                    {
                        Cotizacion cotizacion = new Cotizacion();
                        cotizacionesGuardadas.Add(JsonSerializer.Deserialize<Cotizacion>(registro));
                    }
                    return cotizacionesGuardadas;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private static bool UnvailableFile(string registro)
        {
            try
            {
                File.AppendAllText(filePath, registro);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
