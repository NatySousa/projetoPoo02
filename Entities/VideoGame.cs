using System;
using Exercicio_02.Interfaces;

namespace Exercicio_02.Entities
{
    public class VideoGame : Produto , IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame()
        {
            
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }
        public double CalculaImposto()
        {  
            var imposto = 0.0;
            if (IsUsado)
            {
                imposto = Preco * 0.25;
                Console.WriteLine($"Imposto {Nome} {Modelo} usado, R$ {imposto} ");
                return imposto;
            }
            else
            {
                imposto = Preco * 0.45;
                Console.WriteLine($"Imposto {Nome} {Modelo} novo, R$ {imposto} ");
                return imposto;
            }
        }
    }

}