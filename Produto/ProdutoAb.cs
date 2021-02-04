using System;

namespace Produto
{
    abstract class ProdutoAb
    {
        protected string nome { get; set; }
        protected double preco { get; set; }

        protected int qtd { get; set; }

     
        public ProdutoAb(string nome, double preco, int qtd)
        {
            this.preco = preco;
            this.nome = nome;
            this.qtd = qtd;

        }

        public void setNome(string nome) { this.nome = nome; }
        public string getNome() { return this.nome; }
        public void setPreco(double preco) { this.preco = preco; }
        public double getPreco() { return this.preco; }

        public void setQtd(int qtd) { this.qtd = qtd; }
        public int getQtd() { return this.qtd; }


    }
}