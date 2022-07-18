using System.Globalization;

namespace ExercicioSecao05 {
    internal class ContaBancaria {


        private int _numero;
        private string Titular { get; set; }
        private double Saldo;


        public int Numero {
            get {
                return _numero;
            }  
        }
        public void CadastroNumero(int num) {
           _numero = num; ;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor+5;

        }

        public ContaBancaria(int numero, string nome, double valor) {
            _numero = numero;
            Titular = nome;
            Saldo = valor;
        }

        public override string ToString() {
            return "\nNome: " + Titular + "\nNumero da Conta: " + _numero
                + "\nSaldo $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }







    }
}
