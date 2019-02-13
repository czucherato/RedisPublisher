using System;
using StackExchange.Redis;

namespace RedisPublisher.Persistencia.Contexto.Interfaces
{
    public interface IConexao : IDisposable
    {
        void Fechar();

        IConnectionMultiplexer Abrir();

        IConnectionMultiplexer Sessao { get; }

        bool HaConexao();
    }
}
