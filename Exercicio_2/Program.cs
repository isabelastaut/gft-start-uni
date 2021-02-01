using Exercicio_2.Models;
using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Aneis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("C# POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja Americanas = new Loja("Americanas", "12345678", livros, games);


            Console.WriteLine("------------- Testando cálculo de impostos -------------");
            Console.WriteLine("");

            l2.CalculaImposto();
            l3.CalculaImposto();
            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            Console.WriteLine("");
            Console.WriteLine("------------- Fim do teste cálculo de impostos -------------");

            Console.WriteLine("");

            Console.WriteLine("------------- Testando métodos ListaLivros e ListaVideoGames -------------");
            Console.WriteLine("");

            Americanas.ListaLivros();
            Console.WriteLine("");
            Americanas.ListaVideoGames();

            Console.WriteLine("");
            Console.WriteLine("------------- Fim dos testes de métodos ListaLivros e ListaVideoGames -------------");

            Console.WriteLine("");

            Console.WriteLine("------------- Testando métodos CalculaPatrimonio -------------");
            Console.WriteLine("");

            Americanas.CalculaPatrimonio();

            Console.WriteLine("");
            Console.WriteLine("------------- Fim do teste -------------");

        }
    }
}
