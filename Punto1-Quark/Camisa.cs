using System;
using System.Collections.Generic;
using System.Text;

namespace Punto1_Quark
{
    public class Camisa : Prenda
    {
        public enum Cuello { Mao, Comun }
        private Cuello cuello;
        public enum Manga { Corta, Larga }
        private Manga manga;

        public Camisa(Calidad quality, decimal price, Cuello cuello, Manga manga) : base (quality, price)
        {
            this.cuello = cuello;
            this.manga = manga;
            SetName();
        }       
        public Camisa()
        {

        }

        public Cuello CuelloCamisa
        {
            get { return cuello; }
            set { cuello = value; }
        }

        public Manga MangaCamisa
        {
            get { return manga; }
            set { manga = value; }
        }        

        public override void SetName()
        {
            prendaName = manga == Camisa.Manga.Corta ? cuello == Camisa.Cuello.Mao ? "Camisa manga corta - cuello mao" : "Camisa manga corta" : cuello == Camisa.Cuello.Mao ? "Camisa manga larga cuello mao" : "Camisa manga larga";
            prendaName += quality == Prenda.Calidad.Standard ? " estándar" : " premium";
        }
    }
}
