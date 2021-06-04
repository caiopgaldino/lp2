using System;
using System.Collections.Generic;
using System.Text;

namespace Aula14
{
   public class Fornecedores : IImprimivel
    {
        private string _nome;
        private string _cnpj;
        private string _tel;
        private List<Produto> _item;
        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string Cnpj
        {
            get
            {
                return this._cnpj;
            }
        }
          public string Tel
        {
            get
            {
                return this._tel;
            }
        }
        public Fornecedores(string nome, string tel, string cnpj, List<Produto>produtos)
        {
            this._nome = nome;
            this._cnpj = cnpj;
            this._tel = tel;
            this._item = produtos;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome);
            Console.WriteLine("CNPJ:\t{0}", this.Cnpj);
            Console.WriteLine("Telefone:\t{0}", this.Tel);
            foreach (var item in _item)
            {
                item.Imprimir();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
