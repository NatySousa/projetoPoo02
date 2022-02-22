using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_02.Entities
{
    public class Loja 
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }
        
        public Loja()
        {
            
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames =videoGames;
        }

        public void ListaLivros ()
        {
          if (Livros.Count() == 0)
          {
             Console.WriteLine ("A loja não tem livros no seu estoque.");
          }
          else 
          {
              foreach (var item in Livros)
              {
                Console.WriteLine($"Nome do livro: {item.Nome}");
                Console.WriteLine($"Preco do livro: {item.Preco}");
                Console.WriteLine($"Autor do livro: {item.Autor}");
                Console.WriteLine($"Tema do livro: {item.Tema}");
                Console.WriteLine($"Quantidade do livro: {item.Qtd}");

              }
          }
        }

        public void ListaVideogames () 
        {
            
          if (VideoGames.Count() == 0)
          {
             Console.WriteLine ("A loja não tem video-games no seu estoque.");
          }
          else 
          {
              foreach (var item in VideoGames)
              {
                Console.WriteLine($"Nome do Video Game: {item.Nome}");
                Console.WriteLine($"Preco do Video Game: {item.Preco}");
                Console.WriteLine($"Marca do Video Game: {item.Marca}");
                Console.WriteLine($"Modelo do Video Game: {item.Modelo}");
                Console.WriteLine($"O Video Game é novo?: {item.IsUsado}");

              }

            }
        }
        
         public double CalculaPatrimonio() 
         {
            var somaVideoGames = 0.0; 
            
            foreach (var item in VideoGames)
            {
                somaVideoGames = somaVideoGames + (item.Qtd * item.Preco);
            }

            var somaLivros = 0.0;

            foreach (var item in Livros)
            {
                somaLivros = somaLivros + (item.Qtd * item.Preco);
            }

            var total = somaVideoGames + somaLivros;
            Console.WriteLine($"O patrimômio da loja: {Nome} é de R$ {total}");
            return total;
         }
    }
}