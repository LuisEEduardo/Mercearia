using System;
using Mercearia.Models.VendaContext;
using System.Globalization;
using System.Collections.Generic;
using Mercearia.Data;
using Dapper;

namespace Mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();            

            // DbSession _db = new DbSession();
            // using (var con = _db.Connection)
            // {
            //     Console.WriteLine("Hello World");

            //     var query = @"  SELECT *
            //                     FROM [Produto]";

            //     var produtos = con.Query<Produto>(query);
            //     foreach (var produto in produtos)
            //     {
            //         Console.WriteLine(produto.Preco);
            //     }
            // }


            // List<Produto> produtosDisponiveis = ProdutosDoDia(); 

            // ItemCarrinho itemLeite = new ItemCarrinho(produto, 5);
            // ItemCarrinho itemManga = new ItemCarrinho(manga, 10);
            // ItemCarrinho itemMelancia = new ItemCarrinho(melancia, 1);

            // CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            // carrinho.AddItens(itemLeite);
            // carrinho.AddItens(itemManga);
            // carrinho.AddItens(itemMelancia);

            // Caixa caixa = new Caixa();
            // caixa.AddCarrinho(carrinho);

            // Console.WriteLine($"O valor total das compras: {caixa.ValorTotal().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");

        }

        // public static List<Produto> ProdutosDoDia()
        // {
        //     List<Produto> produtos = new List<Produto>();
        //     Produto leite = new Produto("Leite", 5.00M, "Leite natural");
        //     Produto manga = new Produto("Manga", 2.00M, "Manga do pé");
        //     Produto melancia = new Produto("Melancia", 10.00M, "Melancia da fazenda do Zé");
        //     produtos.Add(leite);
        //     produtos.Add(manga);
        //     produtos.Add(melancia);
        //     return produtos;
        // }
    }
}
