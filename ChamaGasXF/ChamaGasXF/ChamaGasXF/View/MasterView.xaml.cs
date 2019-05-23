using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamaGasXF.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChamaGasXF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterView : MasterDetailPage
    {
        public static MasterDetailPage NavegacaoMasterDetail { get; set; }
        public MasterView()
        {
            InitializeComponent();
            this.Detail = new NavigationPage(new HomeView()
            {
                Title = "ChamaGás",
                Icon = ""
            });
            this.Master = new MenuView()
            {
                Title = "Menu"
            };
            this.MasterBehavior = MasterBehavior.Popover;

            MasterView.NavegacaoMasterDetail = this;
        }
    }
}