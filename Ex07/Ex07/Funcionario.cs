using System;
using System.Globalization;

namespace Ex07 {
    public class Funcionario {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public void AumentoSalario(double porcentagem) {
            porcentagem = salarioBruto * porcentagem / 1000;
            salarioBruto = salarioBruto + porcentagem;
        }

        public double salarioLiquido() {
            return salarioBruto - imposto;
        }
    }
}
