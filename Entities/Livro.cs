using System;
using Exercicio_02.Interfaces;

namespace Exercicio_02.Entities
{
    public class Livro : Produto , IImposto
    {
       public string Autor { get; set; }
       public string Tema { get; set; }
       public int QtdPaga { get; set; } 

       public Livro()
       {
           
       }

       public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPaga)
       {
           Nome = nome;
           Preco = preco;
           Qtd = qtd;
           Autor = autor;
           Tema = tema;
           QtdPaga = qtdPaga;
       }

        public double CalculaImposto()
        {
            if (Tema == "educativo")
            {
                Console.WriteLine( $"Livro educativo não tem imposto: {Nome}" );
                return 0;
            }
            else
            {
                var imposto = Preco * 0.1;
                Console.WriteLine($"R$ {imposto} de imposto sobre o livro {Nome}");
                return imposto;
            }
        }
    }

    
}