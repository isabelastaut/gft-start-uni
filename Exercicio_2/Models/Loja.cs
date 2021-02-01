using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_2.Models
{
    class Loja
    {
        private string Nome { get; set; }
        private string Cnpj { get; set; }
        private List<Livro> Livros { get; set; }
        private List<VideoGame> VideoGames { get; set; }


        public Loja() { }


        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }


        public void ListaLivros()
        {
            if (!Livros.Any())
            {
                Console.WriteLine($"A loja {Nome} não possui livros no seu estoque");
            }

            else
            {
                Console.WriteLine($"A loja {Nome} possui os seguintes livros a venda:");

                foreach (Livro item in Livros)
                {
                    Console.WriteLine("Título: "
                        + item.Nome
                        + ", preço: R$ "
                        + item.Preco.ToString("F2")
                        + ", quantidade: "
                        + item.Quantidade
                        + " unidades em estoque");
                }
            }
        }


        public void ListaVideoGames()
        {
            if (!VideoGames.Any())
            {
                Console.WriteLine($"A loja {Nome} não possui video games no seu estoque");
            }

            else
            {
                Console.WriteLine($"A loja {Nome} possui os seguintes video games a venda:");

                foreach (VideoGame item in VideoGames)
                {
                    Console.WriteLine("Título: "
                        + item.Nome + item.Modelo
                        + ", preço R$"
                        + item.Preco.ToString("F2")
                        + ", quantidade: "
                        + item.Quantidade
                        + "unidades em estoque.");
                }
            }
        }


        public double CalculaPatrimonio()
        {
            double patrimonio = 0;

            foreach (Livro item in Livros)
            {
                patrimonio += item.Preco * item.Quantidade;
            }

            foreach (VideoGame item in VideoGames)
            {
                patrimonio += item.Preco * item.Quantidade;
            }

            Console.WriteLine($"O patrimônio da loja {Nome} é de R${patrimonio.ToString("F2")}.");

            return patrimonio;
        }
    }
}
