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
        public void Atz_Estoque(Compra compra)
        {
            int x = 0;
            foreach (KeyValuePair<Produto, int> parordenado in compra.Carrinho.Itens)
            {
                int quantidade = _produtos[parordenado.Key];
                if (parordenado.Value > quantidade && x == 0)
                {
                    Console.WriteLine("A compra do cliente {0} não pôde ser realizada", compra.Cliente.Nome);
                    Console.WriteLine("Só temos {0} unidades do produto {1} em nosso estoque, por favor cliente {2}," +
                        " atualize a quantidade deste item para um disponível em nosso estoque "
                        , quantidade, parordenado.Key.Nome, compra.Cliente.Nome);
                    x = x + 1;
                    break;
                }
            }
            if (x==0)
                {
                    foreach (Produto qualquercoisa in compra.Carrinho.Itens.Keys)
                    {

                        if (_produtos.ContainsKey(qualquercoisa))
                        {
                            this._produtos[qualquercoisa] = this._produtos[qualquercoisa] - compra.Carrinho.Itens[qualquercoisa];
                        }
                        
                    }
                    Console.WriteLine("A compra do cliente {0} foi concluída com sucesso", compra.Cliente.Nome);
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
