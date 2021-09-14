using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public class Vendedor
    {
        private int idVendedor;
        private string name;
        private string lastName;
        public List<Cotizacion> cotizacionList;
                
        public Vendedor(int id, string name, string lastName, List<Cotizacion> cotizacionHistory)
        {
            idVendedor = id;
            this.name = name;
            this.lastName = lastName;
            cotizacionList = new List<Cotizacion>();
            SetCotizacionList(cotizacionHistory);
        }

        public Cotizacion CrearCotizacion(Prenda prenda, int units, int idCotizacion)
        {
            Cotizacion cotizacion = new Cotizacion(idCotizacion, idVendedor, prenda, units);
            cotizacionList.Add(cotizacion);
            SaveUtils.SaveCotizacion(cotizacion);
            return cotizacion;
        }

        private void SetCotizacionList(List<Cotizacion> cotizacionHistory)
        {
            if (cotizacionHistory != null)
            {
                foreach (Cotizacion cotizacion in cotizacionHistory)
                {
                    if (cotizacion.IDVendedor == idVendedor)
                    {
                        cotizacionList.Add(cotizacion);
                    }
                }
            }
        }

        public string NombreYApellido
        {
            get { return name + " " + lastName; }
        }
        public int IDVendedor
        {
            get { return idVendedor; }
        }
    }
}

