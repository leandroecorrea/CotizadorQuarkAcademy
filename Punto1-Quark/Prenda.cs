using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public abstract class Prenda
    {
        public enum Calidad { Standard, Premium }
        protected Calidad quality;
        protected decimal price;
        protected string prendaName;
        
        public Prenda ()
        {
            prendaName = "";
        }
        public Prenda(Calidad quality, decimal price)
        {            
            this.quality = quality;
            this.price = price;
            prendaName = "";
        }

        public virtual string PrendaName()
        {
            return prendaName;
        }

        public abstract void SetName();       

        public virtual decimal Price
        {
            get { return price; }
            set { price = value; }        
        }

        public virtual Calidad Quality
        {
            get { return quality; }
            set { quality = value; }
        }
    }
}
