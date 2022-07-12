using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09CalculoRaio_Instanciado {
    public class Calculadora {
        public double r;
        public double pi = 3.14;

        public double Circunferencia(double r) {
            return 2 * pi * r;
        }

        public double Volume(double r ) {
            return 4.0 / 3.0 * pi * r * r * r;
        }

    }
}
   
