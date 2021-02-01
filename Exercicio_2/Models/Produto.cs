using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    abstract class Produto
    {
        public string Nome { get; protected set; }
        public double Preco { get; protected set; }
        public int Quantidade { get; protected set; }


        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
