using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace appRemesas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Obtén una referencia al ListView desde el diseño
            listView = FindViewById<ListView>(Resource.Id.listView1);

            // Crea una lista de elementos de ejemplo


            // Crea un adaptador personalizado para el ListView
            var adapter = new AdapterCustomListRemesa(this, Global.Remesas) ;

            // Asigna el adaptador al ListView
            listView.Adapter = adapter;
            //vLista.ItemClick += VLista_ItemClick;
            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activity_Detalle_Remesa));
            //OBTENER ID DE LA REGION SELECCIONADA
            RemesaFamiliar temp = Global.Remesas[e.Position];
            i.PutExtra("id", temp.Id);
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}