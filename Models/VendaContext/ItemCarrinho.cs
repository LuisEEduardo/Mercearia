using System;
using System.Diagnostics.CodeAnalysis;
using Mercearia.Models.SharedContext;

namespace Mercearia.Models.VendaContext
{
    public class ItemCarrinho : Base, IEquatable<ItemCarrinho>
    {
        public ItemCarrinho(Produto produto, int qtd)
            : base()
        {
            Produto = produto;
            Qtd = qtd;
        }
        public Produto Produto { get; set; }
        public int Qtd { get; private set; }

        public double ValorTotalItem()
        {
            return Qtd * Produto.Preco;
        }

        public void AddQtdProduto(int qtd)
        {
            if (qtd > 0)
            {
                Qtd += qtd;
            }
        }

        public void RemoveQtdProduto(int qtd)
        {
            if (qtd > 0)
            {
                Qtd -= qtd;
            }
        }

        public bool Equals([AllowNull] ItemCarrinho other)
        {
            return Produto.Nome == other.Produto.Nome;
        }
    }
}