using System;


namespace Secao10HerancaPolimorfismo.Entities
{
    internal class BusinessAccount : Account //herança
    {

        public double LoanLimit { get; set; }

        public void loan(double amount)
        {
            if (amount <=  LoanLimit) 
            {
                Balance += amount;
                LoanLimit -= amount;
            }

        }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double loanlimit ) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }



        public override string ToString()
        {
            return ("Numero da Conta:"+ Number +", Nome: "+ Holder + " Saldo: "+ Balance + " Limite de Emprestimo: "+ LoanLimit);
        }
    }
}
