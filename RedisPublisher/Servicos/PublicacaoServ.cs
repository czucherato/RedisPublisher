using RedisPublisher.Interfaces.Servico;
using RedisPublisher.Modelos.PubicacaoMds;
using RedisPublisher.Interfaces.Repositorio;

namespace RedisPublisher.Servicos
{
    public class PublicacaoServ : IPublicacaoServ
    {
        public PublicacaoServ(IPublicacaoRep rep)
        {
            this._rep = rep;
        }

        private readonly IPublicacaoRep _rep;

        public void Enviar(EnviarMd comando)
        {
            this._rep.Enviar(comando);
        }
    }
}
