using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class VideoGame : Produto, IImposto
    {
        private string Marca { get; set; }
        public string Modelo { get; private set; }
        private bool IsUsado { get; set; }


        public VideoGame() { }


        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool isUsado)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public double CalculaImposto()
        {
            double imposto;

            if (IsUsado)
            {
                imposto = Preco * 0.25;
                Console.WriteLine($" O imposto sobre o video game {Nome} {Modelo} usado é R${imposto.ToString("F2")}.");
            }

            else
            {
                imposto = Preco * 0.45;
                Console.WriteLine($"O imposto sobre o video game {Nome} {Modelo} é R${imposto.ToString("F2")}.");
            }

            return imposto;
        }
    }
}
