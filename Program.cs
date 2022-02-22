using System;
using System.Collections.Generic;
using Exercicio_02.Entities;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            var l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            var l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            var v1 =  new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            var v2 =  new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            var v3 =  new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            var listaLivros = new List<Livro>();
            listaLivros.Add(l1);
            listaLivros.Add(l2);
            listaLivros.Add(l3);

            var listaVideoGames = new List<VideoGame>();
            listaVideoGames.Add(v1);
            listaVideoGames.Add(v2);
            listaVideoGames.Add(v3);

            var loja = new Loja("Americanas", "1234567890", listaLivros, listaVideoGames);
            
            l2.CalculaImposto();     
            l3.CalculaImposto();

            v2.CalculaImposto();     
            v1.CalculaImposto(); 

            loja.ListaLivros();
            loja.ListaVideogames(); 
            loja.CalculaPatrimonio(); 

        }
    }
}
