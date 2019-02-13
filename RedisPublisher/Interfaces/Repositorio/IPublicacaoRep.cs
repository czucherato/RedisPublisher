using RedisPublisher.Modelos.PubicacaoMds;

namespace RedisPublisher.Interfaces.Repositorio
{
    public interface IPublicacaoRep
    {
        void Enviar(EnviarMd comando);
    }
}
