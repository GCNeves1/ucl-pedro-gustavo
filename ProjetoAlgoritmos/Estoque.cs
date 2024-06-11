using System;
using System.Collections.Generic;

namespace Padaria
{

    class estoque
    {
        private string produto { get; set; }
        private float valor { get; set; }

        //produto
        public string GetProduto()
        {
            return this.produto;
        }

        public void SetProduto(string produto)
        {
            this.produto = produto;
        }

        //valor
        public float GetValor()
        {
            return this.valor;
        }

        public void SetValor(float valor)
        {
            this.valor = valor;
        }
    }
}