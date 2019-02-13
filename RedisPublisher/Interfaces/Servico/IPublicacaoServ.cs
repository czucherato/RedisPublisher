using RedisPublisher.Modelos.PubicacaoMds;

namespace RedisPublisher.Interfaces.Servico
{
    public interface IPublicacaoServ
    {
        void Enviar(EnviarMd comando);
    }
}
