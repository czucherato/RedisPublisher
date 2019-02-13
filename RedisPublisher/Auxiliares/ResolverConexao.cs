using System.Configuration;
using RedisPublisher.Persistencia.Contexto.Interfaces;

namespace RedisPublisher.Auxiliares
{
    public class ResolverConexao : IResolverConexao
    {
        public string ObterConnectionString() => ConfigurationManager.ConnectionStrings["BancoRedis"].ConnectionString;
    }
}
