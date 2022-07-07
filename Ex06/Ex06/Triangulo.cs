using System.Globalization;
using System;

namespace Ex06 {
    public class Retangulo {

        public double largura;
        public double altura;


        public double Area(double largura, double altura) { 
            return largura * altura;
        }

        public double Perimetro(double largura, double altura) {
            return largura + altura + largura + altura ;
        }

        public double Diagonal(double largura, double altura) {
            double diag = (largura*largura) + (altura*altura);
            return Math.Sqrt(diag);
        }

        
    }
}
