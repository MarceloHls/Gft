using System;

namespace Produto
{
    class Livro : ProdutoAb, Imposto
    {
        private string autor { get; set; }
        private string tema { get; set; }

        private int qtdPaginas { get; set; }


        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPaginas)
        : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPaginas = qtdPaginas;

        }

        public double Calcular()
        {
            if (this.tema.Equals("educativo"))
            {
                return this.preco ;
            }
            return this.preco - (preco * 0.10);
        }

        public void setAutor(string autor) { this.nome = autor; }
        public string getAutor() { return this.nome; }
        public void setTema(string tema) { this.tema = tema; }
        public string getTema() { return this.nome; }

        public void setQtdPaginas(int qtdPaginas) { this.qtdPaginas = qtdPaginas; }
        public int getQtdPaginas() { return this.qtdPaginas; }


    }
}