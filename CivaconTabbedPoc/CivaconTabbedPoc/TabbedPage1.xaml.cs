using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CivaconTabbedPoc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {

            var response = await DisplayAlert("Warning", "Are you sure", "Yes", "Cancel");
            if (response)
                DisplayAlert("Done", "really want to delete", "OK");
            // var response= await  DisplayActionSheet("Titile" ,"Cancel","Delete","Copy link","Message","Email");
            //await  DisplayAlert("Response", response, "ok");
        }

        private void Button_ClickedPrimeryToolbar(object sender, EventArgs e)
        {
            DisplayAlert("Activation", "Enable Tool bar ", "OK");

        }
    }
}