using System;
using System.Globalization;

namespace ExercicioSecao05Properties

{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade = 10;

        public string Nome
        { //properties
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        { //properties
            get { return _preco; }
            set { _preco = value; }
        }

        public int Quantidade
        { //properties

            get { return _quantidade; }
            
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