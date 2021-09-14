using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public class Tienda
    {
        private string name;
        private string address;        
        private Vendedor vendedor;
        private List<Cotizacion> cotizacionList;
        private int idCotizacion;

        public Tienda()
        {
            name = "Quark Store";
            address = "www.quarkstore.com.ar/";
            idCotizacion = 0;
        }
        
       
        public Vendedor Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        public int IDCotizacion()
        {
            if(cotizacionList != null)
            {                
                return idCotizacion = cotizacionList.Count + 1;
            }
            else
            {                
                return idCotizacion;
            }
        }

        public List<Cotizacion> AllCotizaciones()
        {
            cotizacionList = SaveUtils.LoadCotizaciones();
            return cotizacionList; 
        }
        public int StockChecker(Prenda prenda)
        {            
            return prenda is Camisa ? StockCamisas(prenda as Camisa) : StockPantalones(prenda as Pantalon);
        }

        private int StockCamisas(Camisa camisa)
        {
            return camisa.MangaCamisa == Camisa.Manga.Corta ? camisa.CuelloCamisa == Camisa.Cuello.Mao ? 100 : 150 : camisa.CuelloCamisa == Camisa.Cuello.Mao ? 75 : 175;
        }

        private int StockPantalones(Pantalon pantalon)
        {
            return pantalon.CortePantalon == Pantalon.Corte.Chupin ? 750 : 250;
        }
        
        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
        }

    }
}
