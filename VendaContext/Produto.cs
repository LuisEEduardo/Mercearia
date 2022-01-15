using Mercearia.SharedContext;

namespace Mercearia.VendaContext
{
    public class Produto : Base
    {
        public Produto(string nome, double preco, string descricao)
            : base()
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

    }

}