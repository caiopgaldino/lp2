using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
   public class Compra: IImprimivel
    {
        private Cliente _cliente;
        private Carrinho _carrinho;
        public Cliente Cliente
        {
            get
            {
                return this._cliente;
            }
        }

        public Carrinho Carrinho
        {
            get
            {
                return this._carrinho;
            }
        }
        public Compra(Cliente cliente, Carrinho carrinho)
        {
            this._cliente = cliente;
            this._carrinho = carrinho;
        }
        public void Imprimir()
        {
            this.Cliente.Imprimir();
            this.Carrinho.ImprimirCarrinho();
        }
    }
}
