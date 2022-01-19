using System;
using Mercearia.VendaContext;
using System.Globalization;

namespace Mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Produto leite = new Produto("Leite", 5.00, "Leite natural");
            Produto manga = new Produto("Manga", 2.00, "Manga do pé");
            Produto melancia = new Produto("Melancia", 10.00, "Melancia da fazenda do Zé");

            ItemCarrinho itemLeite = new ItemCarrinho(leite, 5);
            ItemCarrinho itemManga = new ItemCarrinho(manga, 10);
            ItemCarrinho itemMelancia = new ItemCarrinho(melancia, 1);

            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.AddItens(itemLeite);
            carrinho.AddItens(itemManga);
            carrinho.AddItens(itemMelancia);

            Caixa caixa = new Caixa();
            caixa.AddCarrinho(carrinho);

            Console.WriteLine($"O valor total das compras: {caixa.ValorTotal().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");

        }
    }
}
