using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public class Pantalon : Prenda
    {
        public enum Corte { Comun, Chupin }
        private Corte corte;

        public Pantalon(Calidad quality, decimal price, Corte corte) : base(quality, price)
        {
            this.corte = corte;
            SetName();
        }
        
        public Pantalon ()
        {

        }

        public Corte CortePantalon
        {
            get { return corte; }
            set { corte = value; }
        }

        public override void SetName()
        {
            prendaName += corte == Pantalon.Corte.Chupin ? "Pantalon chupín" : "Pantalon estándar";
            prendaName += quality == Prenda.Calidad.Standard ? " estándar" : " premium";
        }
    }
}
