using System;
using System.Globalization;


namespace Ex05_ClassProduto {
    public class Produto {
        public string nome;
        public double preco;
        public int quantidade;


        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int x) {
            quantidade += x;
            
        }

        public void RemoverProdutos(int x) {
            quantidade -= x;
        }

        public override string ToString() {
            return nome + 
                ", $" + 
                preco.ToString("F2", CultureInfo.InvariantCulture) + 
                ", QTD: " + 
                quantidade + 
                " Total: " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
