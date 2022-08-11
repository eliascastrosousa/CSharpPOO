using System;
using Secao10HerancaPolimorfismo.Entities;

namespace Secao10HerancaPolimorfismo.Entities
{
    internal class Heranca
    {
        public void heranca()
        {
            Account Conta = new Account(2001525, "Elias Castro", 500.25);

            BusinessAccount ContaJuridica = new BusinessAccount(2001525000, "CO&Elias.Info", 3000, 5000);

            ContaJuridica.loan(100);
            Console.WriteLine(Conta);
            Console.WriteLine(ContaJuridica);

            SavingsAccount taxaJuros = new SavingsAccount(2001525, "Elias Castro", 500.25, 0.2);//20% = 100,05 600,30
            taxaJuros.updateBalance(0.2);
            Console.WriteLine(taxaJuros);
        }
    }
}
