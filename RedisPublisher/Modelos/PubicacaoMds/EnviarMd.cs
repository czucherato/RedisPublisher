namespace RedisPublisher.Modelos.PubicacaoMds
{
    public class EnviarMd
    {
        public EnviarMd(string canal, string texto)
        {
            this.Canal = canal;
            this.Texto = texto;
        }

        public string Canal { get; private set; }
        public string Texto { get; private set; }
    }
}
