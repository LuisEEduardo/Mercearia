using System.Collections.Generic;
using System.Linq;
using Dapper;
using Mercearia.Data;
using Mercearia.Models.VendaContext;

namespace Mercearia.Models.Repositories
{
    public class RepositoryProduto
    {
        private DbSession _db { get; set; }

        public List<Produto> ListaTodosProdutos()
        {
            using (var con = _db.Connection)
            {
                string query = @"   SELECT *
                                    FROM [Produtos]"; 
                var produtos = con.Query<Produto>(query).ToList();                         
                return produtos;
            }
        }

    }
}