using RedisPublisher.Modelos.PubicacaoMds;

namespace RedisPublisher.Interfaces.Aplicacao
{
    public interface IPublicacaoApp
    {
        void Enviar(EnviarMd comando);
    }
}
