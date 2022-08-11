using System;
using Secao10HerancaPolimorfismo.Entities;

namespace Secao10HerancaPolimorfismo.Entities
{
    internal class UpcastingDowncasting
    {
        public void upcastingDowncasting()
        {
            BusinessAccount ContaJuridica = new BusinessAccount(2001525000, "CO&Elias.Info", 3000, 5000);

            // upcasting
            //recebe um objeto de qualquer subclasse dela

            Console.WriteLine("");
            Account acc1 = ContaJuridica;
            Account acc2 = new BusinessAccount(100100, "Caio Rodrigues", 0.0, 2500.0);
            Account acc3 = new SavingsAccount(100125, "Karina", 0.0, 0.01);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);

            //quando vc faz upcast, alguns atributos desse objeto, como funções, não irão funcionar por exemplo o acc2,
            //é um objeto bussinesAccount, porém foi convertido para account, se vc printar o objeto,
            //ele irá mostrar com as propriedades do business acount, mas vc nao consegue usar funções de adição ou remoção 

            //acc2.loan(100.00);

            //necessario fazer Downcasting

            //DOWNCASTING
            //para converter um objeto que foi feito upcasting, necessario informar fazendo o downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.loan(100.00);
            Console.WriteLine(acc4);

            //downcasting não funciona de subclasse para subclasse
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            //metodo is

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            else
            {
                Console.WriteLine("\nNão foi possivel fazer Downcasting de acc3 para BusinessAccount ");
            }

            if (acc2 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc2;
                Console.WriteLine("Downcast feito");
                acc5.loan(200);
                Console.WriteLine(acc5);
            }
            else
            {
                Console.WriteLine("\nNão foi possivel fazer Downcasting de acc3 para BusinessAccount ");
            }
        }
    }
}