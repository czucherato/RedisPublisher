using StackExchange.Redis;

namespace RedisPublisher.Persistencia.Contexto.Interfaces
{
    public interface IConexaoPublicador : IConexao
    {
        ISubscriber Inscrito { get; }
    }
}
