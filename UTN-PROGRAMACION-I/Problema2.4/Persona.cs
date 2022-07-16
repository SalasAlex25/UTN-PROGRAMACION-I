using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._4
{
     class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public Persona()
        {
            nombre = string.Empty;
            edad = 0;
            sexo = string.Empty;
            altura = 0;
            peso = 0;
        }
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        public double CalcularIMC()
        {
            double pesoideal;

            pesoideal = peso / (altura * 2);
            if (pesoideal < 20)
            {
                return -1;

            } if (pesoideal >= 20 || pesoideal <= 25)
            {
                return 1;


            }
            if(pesoideal > 25)
            {
                return 0;
            }

            return pesoideal;
            
        }

        public bool EsMayorDeEdad()
        {
            bool esMayorDeEdad;
            if(edad >= 21)
            {
                esMayorDeEdad = true;
            }else
            {
                esMayorDeEdad=false;
            }
            return esMayorDeEdad;
        }




    }
}
