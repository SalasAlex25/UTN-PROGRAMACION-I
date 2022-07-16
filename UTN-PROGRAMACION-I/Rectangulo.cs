using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN_PROGRAMACION_I
{
     class Rectangulo
    {
       private double altura;
       private double Base;

        public Rectangulo()
        {
            altura = 5;
            Base = 3;
        }

        public void CalcularPerimetro()
        {
            double perimetro;
            perimetro = 2 * altura + 2 * Base;

            Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");
        }

        public void CalcularSuprficie()
        {
            double suprficie;
            suprficie = altura * Base;
            Console.WriteLine($"La Superficie del rectangulo  es: {suprficie}");
        }
    }
}
