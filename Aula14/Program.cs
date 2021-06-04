using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
            Assinatura cottonshopi =
                new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
            Assinatura premillere =
                new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");
            Licensa corehul = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM");

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45);

            Carrinho carrinho = new Carrinho();
            
            carrinho.Adicionar(rwindols);
            carrinho.Adicionar(alface123, 3);
            carrinho.Adicionar(cottonshopi);
            carrinho.Adicionar(premillere);
            carrinho.Adicionar(corehul);
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);
            carrinho.ImprimirCarrinho();

            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.AdicionarItem(corehul);
            relatorioArtistico.ImprimirRelatorio();

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");
            
            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();
            

             Compra comprinhas = new Compra(hermenegildo, carrinho);
            Compra compronas = new Compra(zoroastra, carrinho);
            Relatorio relatorioCompras = new Relatorio("Relatório de Compras","Este relatório apresenta uma lista de todas as compras no mês de abril");
            relatorioCompras.AdicionarItem(comprinhas);
            relatorioCompras.AdicionarItem(compronas);
            relatorioCompras.ImprimirRelatorio();


            List<Produto>produtos = new List<Produto>();
            produtos.Add(corehul);
            produtos.Add(lepetope);
            Fornecedores michaelsofit = new Fornecedores("Michaelsófit"," 4002.89.22", produtos);
            List<Produto> produtoes = new List<Produto>();
            produtoes.Add(corehul);
            produtoes.Add(lepetope);
            Fornecedores epou = new Fornecedores("Épou", "1221.04.99", produtoes);
            Relatorio relatorioFornecedores = new Relatorio("Relatório de Fornecedores", "Este relatório apresenta com os nossos Fornecedores");
            relatorioFornecedores.AdicionarItem(michaelsofit);
            relatorioFornecedores.AdicionarItem(epou);
            relatorioFornecedores.ImprimirRelatorio();
            
            //instanciando os itens do estoque
            Dictionary<Produto, int> artefatos = new Dictionary<Produto, int>();
            artefatos.Add(rwindols,1000);
            artefatos.Add(alface123,1000);
            artefatos.Add(cottonshopi,1000);
            artefatos.Add(premillere,1000);
            artefatos.Add(mausi,1000);
            artefatos.Add(lepetope,1000);
            // instacinado estoque
            Estoque estoque = new Estoque(artefatos);
            // atualizando o estoque a partir das compras feitas por Hermenegildo e zoroastra
            estoque.Atz_Estoque(carrinho);
            estoque.Atz_Estoque(carrinho);
            // gerando relatório de estoque
            Relatorio estocamento = new Relatorio("Estoque de Produtos", " Este relatório apresenta o estoque dos produtos");
            estocamento.AdicionarItem(estoque);
            estocamento.ImprimirRelatorio();
        }
    }
}
