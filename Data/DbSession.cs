using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Mercearia.Data
{
    public sealed class DbSession : IDisposable
    {

        public IDbConnection Connection { get; set; }

        public DbSession()
        {
            // Servidor, Porta; Nome do banco,Usuario, Senha
            Connection = new SqlConnection("Server=localhost,1433;Database=MercadinhoDb;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}