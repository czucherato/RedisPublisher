using System;
using System.Text;
using System.Windows.Forms;
using RedisPublisher.Modelos.PubicacaoMds;
using RedisPublisher.Interfaces.Aplicacao;

namespace RedisPublisher
{
    public partial class Publicacao : Form
    {
        public Publicacao() => InitializeComponent();

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            this.Enviar(new EnviarMd(".NET14", TxtMensagem.Text));
            TxtMensagem.Clear();
        }

        private void Enviar(EnviarMd comando)
        {
            StringBuilder sb = new StringBuilder();

            using (InjecaoDeDependencia injecao = new InjecaoDeDependencia())
            {
                IPublicacaoApp publicacaoApp = injecao.Invocar<IPublicacaoApp>();
                publicacaoApp.Enviar(comando);

                TxtHistorico.Text = sb.Append(TxtHistorico.Text)
                    .Append($"\r\n Publicador: { comando.Texto }").ToString();
            }
        }
    }
}
