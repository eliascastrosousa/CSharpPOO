using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_Vetores {
    internal class ModificadorParametroMain {
        public void Calculadora() {
            
            int num = ModificadorParametroCalculadora.Sum(new int[] { 2, 3, 4 });
            Console.WriteLine(num);
        }
        public void TriplicarValor() {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            CalcTriplicarValorREF.TriplicarValorREF(ref n);

            Console.WriteLine(n);
        }
        public void TriplicarValorOut() {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            int saida;
            CalcTriplicarValorOUT.TriplicarValorOUT(n, out saida);

            Console.WriteLine(saida);
        }
    }
}
