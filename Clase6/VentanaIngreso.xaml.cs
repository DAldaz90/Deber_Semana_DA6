using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clase6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaIngreso : ContentPage
    {
        private const string Url = "http://192.168.100.7/partner/post.php";
        private readonly HttpClient _client = new HttpClient();
        private Datos ItemSeleccionado;

        public VentanaIngreso(Datos itemSeleccionado)
        {
            InitializeComponent();
            this.ItemSeleccionado = itemSeleccionado;
            t_id.Text = itemSeleccionado.id.ToString();
            t_name.Text = itemSeleccionado.name;
            t_second_name.Text = itemSeleccionado.second_name;
            t_phone.Text = itemSeleccionado.phone.ToString();
        }

        private async void get_insert_Clicked(object sender, EventArgs e)
        {

            try
            {

                WebClient cliente = new WebClient();

                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("id", t_id.Text);
                parametros.Add("name", t_name.Text);
                parametros.Add("second_name", t_second_name.Text);
                parametros.Add("phone", t_phone.Text);

                cliente.UploadValues("http://192.168.100.7/partner/post.php", "POST", parametros);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Alerta !", "Error Inesperado!" + ex.Message, "Cerrar");
            }


        }

        private async void get_return_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private const string Url = "http://192.168.100.7/partner/post.php";
        private readonly HttpClient _client = new HttpClient();
        private Datos ItemSeleccionado;

        public VentanaIngreso(Datos itemSeleccionado)
        {
            InitializeComponent();
            this.ItemSeleccionado = itemSeleccionado;
            t_id.Text = itemSeleccionado.id.ToString();
            t_name.Text = itemSeleccionado.name;
            t_second_name.Text = itemSeleccionado.second_name;
            t_phone.Text = itemSeleccionado.phone.ToString();
        }

        private async void get_insert_Clicked(object sender, EventArgs e)
        {

            try
            {

                WebClient cliente = new WebClient();

                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("id", t_id.Text);
                parametros.Add("name", t_name.Text);
                parametros.Add("second_name", t_second_name.Text);
                parametros.Add("phone", t_phone.Text);

                cliente.UploadValues("http://192.168.100.7/partner/post.php", "POST", parametros);

            }

            catch (Exception ex)
            {

                await DisplayAlert("Alerta !", "Error Inesperado!" + ex.Message, "Cerrar");
            }


        }
    }
}