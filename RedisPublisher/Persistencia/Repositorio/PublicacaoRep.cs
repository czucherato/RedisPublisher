using RedisPublisher.Modelos.PubicacaoMds;
using RedisPublisher.Interfaces.Repositorio;
using RedisPublisher.Persistencia.Contexto.Interfaces;

namespace RedisPublisher.Persistencia.Repositorio
{
    public class PublicacaoRep : IPublicacaoRep
    {
        public PublicacaoRep(IConexaoPublicador conexao) => this._conexao = conexao;

        private IConexaoPublicador _conexao;

        public void Enviar(EnviarMd comando)
        {
            this._conexao.Inscrito.Publish(comando.Canal, comando.Texto);
        }
    }
}
