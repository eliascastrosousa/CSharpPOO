using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11Listas {
    internal class Funcionario {
        public int ID { get; set; }
        public string Nome { get; set; }
        private double Salario;

        public Funcionario(int id, string nome, double sal) {
            ID = id;
            Nome = nome;
            Salario = sal;
        }

        public double MostrarSalario() {
            return Salario;
        }

        public void incrementoSalario(double porcentagem) {
            double aumento = (porcentagem*Salario)/100;
            Salario += aumento;
            
        }

        override public string ToString() {
            return ID + " " + Nome + " " + Salario;
        }

        public void entraDados() {
            Console.WriteLine("Digite o ID: ");
            Console.WriteLine("Digite o Nome: ");
            Console.WriteLine("Digite o Salario: ");
        }
    }
    
}
