using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BingMapsRESTToolkit;
//using System.Runtime.Serialization.Json;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace WPF___Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        

        public MapWindow(string adres)
        {
            InitializeComponent();
            SzukaniePoAdresie(adres);
        }
       
        private async void SzukaniePoAdresie(string adres)
        {

            string key = App.Token;
            string query = adres;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://dev.virtualearth.net/REST/v1/Locations");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "dwbfps8KP1QDPg9vK6OI~ZYZIcujm5aaUH-mgu5De2w~ApYEWr9kE5IaeLvDHz78uoDDvAPiFF0xF56Z2h8VUAOy6mS6EvgLWY9v7E2MyLRV");

            string uri = string.Format("?q={0}&maxResults=1&key={1}", query, key);
            var response = await client.GetAsync(uri);
            string resultContent = await response.Content.ReadAsStringAsync();

            Root root = JsonConvert.DeserializeObject<Root>(resultContent);
            double cord1 = root.resourceSets[0].resources[0].geocodePoints[0].coordinates[0];
            double cord2 = root.resourceSets[0].resources[0].geocodePoints[0].coordinates[1];

            mapGrid.Children.Clear();
 
            var mapControl = new Microsoft.Toolkit.Wpf.UI.Controls.MapControl();


            mapControl.Loaded += (sender2, eventArgs) =>
            {
                BasicGeoposition geoposition = new BasicGeoposition() { Latitude = cord1, Longitude = cord2 };
                var center = new Geopoint(geoposition);
                ((Microsoft.Toolkit.Wpf.UI.Controls.MapControl)sender2).TrySetViewAsync(center, 16);
            };
            mapControl.MapServiceToken = App.Token;
            mapGrid.Children.Add(mapControl);
            AddSpaceNeedleIcon(mapControl, cord1, cord2, adres);
        }
        public void AddSpaceNeedleIcon(Microsoft.Toolkit.Wpf.UI.Controls.MapControl mapControl, double cord1, double cord2, string address)
        {
            var MyLandmarks = new List<Windows.UI.Xaml.Controls.Maps.MapElement>();

            Windows.Devices.Geolocation.BasicGeoposition snPosition = new Windows.Devices.Geolocation.BasicGeoposition { Latitude = cord1, Longitude = cord2 };
            Windows.Devices.Geolocation.Geopoint snPoint = new Windows.Devices.Geolocation.Geopoint(snPosition);

            var spaceNeedleIcon = new MapIcon
            {
                Location = snPoint,
                //NormalizedAnchorPoint = new Point(0.5, 1.0),
                ZIndex = 0,
                Title = address
            };

            MyLandmarks.Add(spaceNeedleIcon);

            var LandmarksLayer = new MapElementsLayer
            {
                ZIndex = 1,
                MapElements = MyLandmarks
            };

            mapControl.Layers.Add(LandmarksLayer);

            mapControl.Center = snPoint;
            mapControl.ZoomLevel = 14;

        }
    }
}