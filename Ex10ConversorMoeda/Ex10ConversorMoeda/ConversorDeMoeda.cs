using System;


namespace Ex10ConversorMoeda {
    internal class ConversorDeMoeda {
        public static double dolar;
        public static double cotacao;
        
        
        public static double conversao() {
            double iof = dolar * 0.06;
            return cotacao * (dolar+iof);
        }


    }
}
