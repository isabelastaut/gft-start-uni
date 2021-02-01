using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Livro : Produto, IImposto
    {
        private string Autor { get; set; }
        private string Tema { get; set; }
        private int QuantidadePaginas { get; set; }


        public Livro() { }


        public Livro(string nome, double preco, int quantidade, string autor, string tema, int quantidadePaginas)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Autor = autor;
            Tema = tema;
            QuantidadePaginas = quantidadePaginas;
        }


        public double CalculaImposto()
        {
            double imposto;

            if (Tema.ToUpper().Trim().Equals("EDUCATIVO"))
            {
                imposto = 0;
                Console.WriteLine("Não incide imposto sobre livro educativo.");
            }

            else
            {
                imposto = Preco * 0.10;
                Console.WriteLine($"O imposto sobre o livro {Nome} é R${imposto.ToString("F2")}.");
            }

            return imposto;
        }
    }
}
