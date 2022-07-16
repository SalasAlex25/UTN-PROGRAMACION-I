using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._3
{
     class Punto
    {
        private int coordenadaX;
        private int coordenadaY;

        public int CoordenadaX
        {
            get { return coordenadaX; }
            set { coordenadaX = value; }

        }

        public int CoordenadaY
        {
            get { return coordenadaY; }
            set { coordenadaY = value; }

        }

        public Punto()
        {
            coordenadaX = 10;
            coordenadaY = 15;
        }


        public double CalcularDistancia()
        {

            double distancia = coordenadaX + coordenadaY;

            return distancia;
        }
    }
}
