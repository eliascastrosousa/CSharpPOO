using System;

namespace ExercicioSecao05 {
    internal class ContaBancaria {


        public string  Conta { get; private set; }
        private string _nome;
        private double _saldo;

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value.Length >= 2)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Não foi possivel Cadastrar o nome!");
                }

            }
        }

        public double Saldo {
            get {
                return _saldo;
            }
            set {
                _saldo += value;
            }
        }

        public ContaBancaria(string conta, string nome, double deposito) {
            conta = Conta;
            nome = Nome;
            deposito = Saldo;
        }








    }
}
