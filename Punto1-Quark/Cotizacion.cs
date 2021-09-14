using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public class Cotizacion
    {
        private int idVendedor;
        private int idCotizacion;     
        private int units;
        private decimal totalCotizacion;
        private DateTime cotizacionDate;        
        private Prenda prendaCotizada;
        private string prendaName;

        public Cotizacion(int idCotizacion, int idVendedor, Prenda prenda, int units)
        {
            this.idCotizacion = idCotizacion;
            this.idVendedor = idVendedor;            
            this.units = units;
            this.prendaCotizada = prenda;
            prendaName = prenda.PrendaName();
            totalCotizacion = Cotizador(prenda) * units;            
            cotizacionDate = DateTime.Now;            
        }
        public Cotizacion()
        {

        }

        public Prenda PrendaCotizada
        {
            get { return prendaCotizada; }
        }

        public string PrendaName
        {
            get { return prendaName; }
            set { prendaName = value; }
        }

        public int IDCotizacion
        {
            get { return idCotizacion; }
            set { idCotizacion = value; }
        }

        public int IDVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }
        
        public int Units
        {
            get { return units; }
            set { units = value; }
        }

        public DateTime CotizacionDate
        {
            get { return cotizacionDate; }
            set { cotizacionDate = value; }
        }

        public decimal Cotizador(Prenda prenda)
        {
            if(prenda.Quality == Prenda.Calidad.Premium)
            {
                prenda.Price += prenda.Price * 30 / 100;
            }
            if(prenda is Pantalon)
            {
                if ((prenda as Pantalon).CortePantalon == Pantalon.Corte.Chupin)
                {
                    prenda.Price -= prenda.Price * 12 / 100;
                }                
            }
            else if(prenda is Camisa)
            {
                if((prenda as Camisa).MangaCamisa == Camisa.Manga.Corta)
                {
                    prenda.Price -= prenda.Price * 10 / 100;
                }
                if((prenda as Camisa).CuelloCamisa == Camisa.Cuello.Mao)
                {
                    prenda.Price += prenda.Price * 3 / 100;
                }
            }
            return prenda.Price;
        }

        public decimal TotalCotizacion
        {
            get { return totalCotizacion; }
            set { totalCotizacion = value; }
        }      

    }
}
