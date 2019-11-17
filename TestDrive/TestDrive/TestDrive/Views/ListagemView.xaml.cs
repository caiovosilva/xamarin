using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestDrive.Models;

namespace TestDrive.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public IEnumerable<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo{ Nome="Fusca 87", Preco=3213 },
                new Veiculo{ Nome="Onix 2019", Preco=32130 },
                new Veiculo{ Nome="Tesla 2020", Preco=321300 }
            };

            this.BindingContext = this;

            //Grid
            //listViewVeiculos.ItemsSource = new string[]
            //{
            //    "Fusca 87",
            //    "Onix 2019",
            //    "Tesla"
            //};
        }


        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView());
            //DisplayAlert("Test Drive", String.Format("Você clicou no modelo '{0}', que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "OK");
        }
    }
}
