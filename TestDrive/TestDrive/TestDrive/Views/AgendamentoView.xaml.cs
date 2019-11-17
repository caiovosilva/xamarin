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
    public partial class AgendamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public AgendamentoView(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            this.Title = String.Format("Agendamento {0}", Veiculo.Nome);

            InitializeComponent();
        }
    }
}