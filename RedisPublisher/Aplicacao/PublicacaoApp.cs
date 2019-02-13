using RedisPublisher.Interfaces.Servico;
using RedisPublisher.Interfaces.Aplicacao;
using RedisPublisher.Modelos.PubicacaoMds;

namespace RedisPublisher.Aplicacao
{
    public class PublicacaoApp : IPublicacaoApp
    {
        public PublicacaoApp(IPublicacaoServ serv)
        {
            this._serv = serv;
        }

        private readonly IPublicacaoServ _serv;

        public void Enviar(EnviarMd comando)
        {
            this._serv.Enviar(comando);
        }
    }
}
