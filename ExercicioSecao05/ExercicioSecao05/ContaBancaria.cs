using System.Globalization;

namespace ExercicioSecao05 {
    internal class ContaBancaria {


        public string Conta { get; private set; }
        private string Nome { get; set; }
        private double _saldo;


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

        public override string ToString() {
            return "\nNome: " + Nome + "\nNumero da Conta: " + Conta
                + "Saldo $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }







    }
}
