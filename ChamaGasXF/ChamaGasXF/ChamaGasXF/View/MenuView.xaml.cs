using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamaGasXF.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChamaGasXF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        List<PaginaModel> paginas;
        public MenuView()
        {
            InitializeComponent();
            CarregarLista();
        }

        public void CarregarLista()
        {
            paginas = new List<PaginaModel>();
            paginas.Add(new PaginaModel
            {
                Titulo = "Pessoa",
                Icone = "",
                PaginaView = typeof(PessoaView)
            });
            paginas.Add(new PaginaModel
            {
                Titulo = "Login",
                Icone = "",
                PaginaView = typeof(LoginView)
            });
            paginas.Add(new PaginaModel
            {
                Titulo = "Produto",
                Icone = "",
                PaginaView = typeof(PessoaView)
            });

            lvMenu.ItemsSource = paginas;

        }

        private void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //SELECIONA A PAGINA
            var pagina = e.SelectedItem as PaginaModel;
            if (pagina != null)
            {
                MasterView.NavegacaoMasterDetail.Detail.Navigation.PopToRootAsync();
                //CRIA A PAGINA VIEW
                Page paginaView = Activator.CreateInstance(pagina.PaginaView) as Page;
                MasterView.NavegacaoMasterDetail.Detail.Navigation.PushAsync(paginaView);
                //DESATIVA O ITEM SELECIONADO
                lvMenu.SelectedItem = null;
            }
        }
    }
}