using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase6
{
    public partial class MainPage : ContentPage
    {

        private const string url = "http://192.168.100.7/partner/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Clase6.Datos> _post;

        public MainPage()
        {
            InitializeComponent();
            get();
        }

        public async void get() {
            var content = await client.GetStringAsync(url);
            List<Clase6.Datos> posts = JsonConvert.DeserializeObject<List<Clase6.Datos>>(content);
            _post = new ObservableCollection<Clase6.Datos>(posts);

            MyListView.ItemsSource = _post;

        }

        private async void get_ing_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VentanaIngreso());
        }
    }
}
