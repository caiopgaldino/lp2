using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
   public class Compra: IImprimivel
    {
        private Cliente _cliente;
        private Carrinho _carrinho;
        private DateTime _hora;
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
         public DateTime Hora
        {
            get
            {
                return this._hora;
            }
        }
        public Compra(Cliente cliente, Carrinho carrinho)
        {
            this._cliente = cliente;
            this._carrinho = carrinho;
            this._hora = DateTime.Today;
        }
        public void Imprimir()
        {
            this.Cliente.Imprimir();
            Console.WriteLine(this.Hora.ToString("g"));
            Console.WriteLine("Total do carrinho:\tR$ {0:0.00}", this.Carrinho.Total);
        }
    }
}
