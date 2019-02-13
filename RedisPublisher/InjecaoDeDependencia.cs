using System;
using SimpleInjector;
using RedisPublisher.Servicos;
using RedisPublisher.Aplicacao;
using SimpleInjector.Lifestyles;
using RedisPublisher.Auxiliares;
using RedisPublisher.Interfaces.Servico;
using RedisPublisher.Interfaces.Aplicacao;
using RedisPublisher.Persistencia.Contexto;
using RedisPublisher.Interfaces.Repositorio;
using RedisPublisher.Persistencia.Repositorio;
using RedisPublisher.Persistencia.Contexto.Interfaces;

namespace RedisPublisher
{
    public class InjecaoDeDependencia : IDisposable
    {
        private static Container _container = null;
        private Container Container
        {
            get
            {
                if (Equals(_container, null))
                {
                    Lifestyle lifeStyle = Lifestyle.Singleton;
                    _container = new Container();
                    _container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
                    Registrar(_container, lifeStyle);
                }

                return _container;
            }
        }

        private static void Registrar(Container container, Lifestyle lifeStyle)
        {
            container.Register<IPublicacaoApp, PublicacaoApp>();
            container.Register<IPublicacaoServ, PublicacaoServ>();
            container.Register<IPublicacaoRep, PublicacaoRep>();
            container.Register<IResolverConexao, ResolverConexao>();
            container.Register<IConexaoPublicador, ConexaoPublicador>();
        }

        public Tipo Invocar<Tipo>() where Tipo : class => Container.GetInstance<Tipo>();

        public void Dispose() { }
    }
}
