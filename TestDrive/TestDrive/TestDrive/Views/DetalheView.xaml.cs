using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        private const int VALOR_FREIO_ABS = 800;
        private const int VALOR_AR_CONDICIONADO = 1000;
        private const int VALOR_MP3 = 500;
        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS {
            get {
                return string.Format("Freio ABS - R$ {0}", VALOR_FREIO_ABS);
            }
        }

        public string TextoArCondionado {
            get {
                return string.Format("Ar Condionado - R$ {0}", VALOR_AR_CONDICIONADO);
            }
        }

        public string TextoMP3 {
            get {
                return string.Format("MP3 Player - R$ {0}", VALOR_MP3);
            }
        }

        public bool isFreioABS { get; set; }

        public string TextoTotal {
            get {
                return string.Format("Total: R$ {0}", 
                    Veiculo.Preco
                    + (isFreioABS ? 800 : 0));
            }
        }
        public DetalheView(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            this.Title = String.Format("Detalhe {0}", Veiculo.Nome);

            InitializeComponent();
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}