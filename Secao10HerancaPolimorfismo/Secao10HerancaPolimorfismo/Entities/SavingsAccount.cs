using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao10HerancaPolimorfismo.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance(double amout)
        {
            Balance += Balance * amout; 
        }

        public override string ToString()
        {
            return base.ToString() + " Taxa de Juros: " + InterestRate;
        }

        public override void withDraw(double amount) //sobreposicao ao metodo da classe Account
        {
            Balance -= amount;
        }

        public override void withDraw(double amount) //sobreposicao ao metodo da classe Account
        {
            base.withDraw(amount); //palavra base faz com que consigamos herdar a função para cá e aplicar além dela, novas funcionalidades
            Balance -= 2.0;
        }


    }
}
