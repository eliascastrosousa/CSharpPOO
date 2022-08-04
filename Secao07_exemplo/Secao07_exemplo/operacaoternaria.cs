using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao07_exemplo {
    internal class operacaoternaria {
        public void opternaria() {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            double desconto = (valor <= 20) ? valor * 0.1 : valor * 0.05;
            Console.WriteLine("Desconto: " + desconto);
        }
    }
}
