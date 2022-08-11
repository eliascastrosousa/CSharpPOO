using System;


namespace Secao10HerancaPolimorfismo.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; } //nome do dono da conta
        public double Balance { get; protected set; }

        public void withDraw(double amount)
        {
            Balance -= amount;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public override string ToString()
        {
            return ("Numero da Conta: " + Number + " Titular: " + Holder + " Saldo: " + Balance);
        }
    }
}
