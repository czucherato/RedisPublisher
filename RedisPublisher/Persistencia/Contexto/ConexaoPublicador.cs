using StackExchange.Redis;
using RedisPublisher.Persistencia.Contexto.Interfaces;

namespace RedisPublisher.Persistencia.Contexto
{
    public class ConexaoPublicador : Conexao, IConexaoPublicador
    {
        public ConexaoPublicador(IResolverConexao resolverConexao)
            : base(resolverConexao) { }

        public ISubscriber Inscrito => !Equals(Sessao, null) ? Sessao.GetSubscriber() : Abrir().GetSubscriber();
    }
}
