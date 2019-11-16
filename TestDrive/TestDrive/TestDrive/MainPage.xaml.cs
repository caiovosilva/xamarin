using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestDrive.Models;

namespace TestDrive
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IEnumerable<Veiculo> Veiculos { get; set; }
        public MainPage()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo{ Nome="Fusca 87", Preco=3213 },
                new Veiculo{ Nome="Onix 2019", Preco=3213 },
                new Veiculo{ Nome="Tesla 2020", Preco=3213 }
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
    }
}
