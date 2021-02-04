using System;
using System.Collections.Generic;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry potter",40,50,"JK","fantasia",300);
            Livro l2 = new Livro("C#",40,50,"professor","educativo",300);

            VideoGame g1 = new VideoGame("PS4",1800,100,"Sony","Slim",false);
            VideoGame g2 = new VideoGame("Xbox",1800,100,"Microsoft","One",true);

            //List<Livro> livros = new List<Livros>();
            List<Livro> livros = new List<Livro>();
            List<VideoGame> videoGames = new List<VideoGame>();



            //Loja americas = new Loja("Americasa","12345");

            Console.WriteLine("---------Testando Impostos--------");
            Console.WriteLine(l1.Calcular());
            Console.WriteLine(l2.Calcular());
            Console.WriteLine(g1.Calcular());
            Console.WriteLine(g2.Calcular());

        }
    }
}
