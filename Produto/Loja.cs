using System;
using System.Collections.Generic;

namespace Produto
{
    public class Loja
    {
        private string nome { get; set; }
        private string cnpj { get; set; }

        private List<Livro> livros = new List<Livro>();
         private List<VideoGame> videoGames = new List<VideoGame>();

        public Loja(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
        
         
        }

        // public void setLivro(List<Livro> livros){

        // }
        

        public void ListarLivros()
        {
            if (livros.Count <= 0)
            {
                Console.WriteLine("Loja não tem Livros");
            }
            else
            {
                livros.ForEach(livro =>
                {
                    Console.Write("Titulo " + livro.getNome());
                    Console.Write(" Preco " + livro.getPreco());
                    Console.WriteLine(" quantidade " + livro.getQtd());
                });
            }

        }
        public void ListarVideoGames()
        {
            if (videoGames.Count <= 0)
            {
                Console.WriteLine("Loja não tem videoGames");
            }
            else
            {
                videoGames.ForEach(videoGame =>
                {
                    Console.Write("Titulo " + videoGame.getNome());
                    Console.Write(" Preco " + videoGame.getPreco());
                    Console.WriteLine(" quantidade " + videoGame.getQtd());
                });
            }
        }

        public void calculaPatrimonio()
        {
            double patrimonio = 0;

            videoGames.ForEach(game => patrimonio = game.getPreco() * game.getQtd());
            livros.ForEach(livro => patrimonio = livro.getPreco() * livro.getQtd());
            Console.WriteLine($"O patrimonio total da Loja {this.nome} é igual a R${patrimonio.ToString("N2")}");
        }


    }
}