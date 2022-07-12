using System;
using System.Globalization;


namespace Aula12Construtores {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga

        public Produto() {

        } //sem nenhum parametro

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int x) {
            Quantidade += x;

        }

        public void RemoverProdutos(int x) {
            Quantidade -= x;
        }

        public override string ToString() {
            return Nome +
                ", $" +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", QTD: " +
                Quantidade +
                " Total: " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}