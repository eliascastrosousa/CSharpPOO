using System;
using Secao10HerancaPolimorfismo.Entities;

namespace Secao10HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Account Conta = new Account(2001525, "Elias Castro", 500.25);

            BusinessAccount ContaJuridica = new BusinessAccount(2001525000, "CO&Elias.Info", 3000, 5000);

            ContaJuridica.loan(100);
            Console.WriteLine(Conta);
            Console.WriteLine(ContaJuridica);


            
        }


    }
}