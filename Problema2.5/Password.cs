using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2._5
{
    class Password
    {
        private int longitud;
        private string valor;

        public Password()
        {
            longitud = 8;
            valor=String.Empty;
        }

        public Password(string valor){
            this.valor = valor;
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Longitud
        {
            get { return longitud; }
        }

        public bool EsFuerte()
        {
            bool esFuerte=false;
            if(valor=="")

            return esFuerte;
        }
        

    }
}
