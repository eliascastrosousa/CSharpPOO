using System;
using Secao10HerancaPolimorfismo.Entities;

namespace Secao10HerancaPolimorfismo.Entities
{
    internal class Sobreposicao
    {
        public void sobreposicao()
        {
            Account acc1 = new Account(1001, "Julio", 500.0);
            Account acc2 = new SavingsAccount(1002, "Pedro", 500.0, 0.01);

            acc1.withDraw(10.00);
            acc2.withDraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
