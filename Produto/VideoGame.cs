using System;

namespace Produto
{
    class VideoGame : ProdutoAb,Imposto
    {
        private string marca { get; set; }
        private string modelo { get; set; }

        private bool isUsado { get; set; }

        public double Calcular(){
           if(this.isUsado){
               return this.preco - (preco * 0.25);
           }
           return this.preco - (preco * 0.45);
        }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;

        }

        public void setMarca(string marca) { this.marca = marca; }
        public string getMarca() { return this.marca; }
        public void setModelo(string modelo) { this.modelo = modelo; }
        public string getModelo() { return this.modelo; }

        public void setIsUsado(bool isUsado) { this.isUsado = isUsado; }
        public bool getIsUsado() { return this.isUsado; }


    }
}