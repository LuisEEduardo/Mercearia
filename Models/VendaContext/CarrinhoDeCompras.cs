using System.Collections.Generic;
using System.Linq;
using Mercearia.Models.SharedContext;

namespace Mercearia.Models.VendaContext
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
            double valorTotal = 0; 
            foreach (var item in Itens)
            {   
                valorTotal += item.ValorTotalItem(); 
            }
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

         public void AdicionarParteDoItem(string nome, int qtd)
        {
            foreach (var produto in Itens.Where(item => item.Produto.Nome == nome))
            {   
                produto.AddQtdProduto(qtd); 
            }            
        }

        public void RemoveParteDoItem(string nome, int qtd)
        {
            foreach (var produto in Itens.Where(item => item.Produto.Nome == nome))
            {   
                produto.RemoveQtdProduto(qtd); 
            }            
        }

    }
}