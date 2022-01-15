using System.Collections.Generic;
using System.Linq;
using Mercearia.SharedContext;

namespace Mercearia.VendaContext
{
    public class CarrinhoDeCompras : Base
    {
        public CarrinhoDeCompras()
        {
            Itens = new List<ItemCarrinho>();
        }
        public IList<ItemCarrinho> Itens { get; private set; }

        public double ValorCarrinho()
        {
            var valorTotal = Itens
                .Select(item => item.Produto.Preco)
                .DefaultIfEmpty(0)
                .Sum();
            return valorTotal;
        }

        public void AddItens(ItemCarrinho item)
        {
            Itens.Add(item);
        }

        public void RemoveTodoItem(ItemCarrinho item)
        {
            Itens.Remove(item);
        }

        // public void RemoveParteDoItem(Produto nome, int qtd)
        // {
        //     var item = Itens.Where(item => item.Produto.Nome.ToString() == nome);             
        // }

    }
}