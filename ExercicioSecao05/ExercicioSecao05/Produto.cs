using System;
using System.Globalization;

namespace ExercicioSecao05
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public string GetNome() //metodo get
        {
            return _nome;
        }

        public void SetNome(string nome) //metodo get
        {
            if (nome != null && nome.Length >1)
            {
                _nome = nome;
            }
        }

        public double GetPreco() //metodo get
        {
            return _preco;
        }
        public void SetPreco(double preco) //metodo get
        {
            _preco = preco;
        }

        public double GetQuantidade() //metodo get
        {
            return _quantidade;
        }
        public void SetQuantidade(int qtd) //metodo get
        {
            _quantidade = qtd;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int x)
        {
            _quantidade += x;

        }

        public void RemoverProdutos(int x)
        {
            _quantidade -= x;
        }

        public override string ToString()
        {
            return _nome +
                ", $" +
                _preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", QTD: " +
                _quantidade +
                " Total: " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}