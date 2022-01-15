using System.Collections.Generic;
using Mercearia.SharedContext;

namespace Mercearia.VendaContext
{
    public class Caixa : Base
    {
        public Caixa()
        {
            CarrinhosDeCompras = new List<CarrinhoDeCompras>();
        }

        public IList<CarrinhoDeCompras> CarrinhosDeCompras { get; set; }
        public double Troco { get; set; }

        public double ValorTotal()
        {
            double valorTotal = 0.0;
            foreach (var carrinho in CarrinhosDeCompras)
            {
                foreach (var item in carrinho.Itens)
                {
                    valorTotal += item.ValorTotalItem();
                }
            }

            return valorTotal;
        }

    }
}