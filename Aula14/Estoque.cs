using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
    public class Estoque : Carrinho
    {
        private Dictionary<Produto, int> _produtos;
        public Dictionary<Produto,int> Produto
        {
               get{
                 return this._produtos;
               }
        }
        public Estoque(Dictionary<Produto,int> produtos)
        {
            this._produtos = produtos;
        }
        public void Atz_Estoque(Carrinho carinho)
        {
        foreach(Produto qualquer in carinho.Itens.Keys)
            {
                if(_produtos.ContainsKey(qualquer))
                {
                    this._produtos[qualquer] = this._produtos[qualquer] - carinho.Itens[qualquer];
                }
            }
        }
        public override void Imprimir()
        {
            Console.WriteLine("======== ESTOQUE ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._produtos)
            {
                Console.WriteLine("Nome:\t{0}", parOrdenado.Key.Nome);
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("==========================");
            }
        }
    }
}
