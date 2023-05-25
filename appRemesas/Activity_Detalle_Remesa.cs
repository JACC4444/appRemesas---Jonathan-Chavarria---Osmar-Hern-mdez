using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appRemesas
{
    [Activity(Label = "Activity_Detalle_Remesa")]
    public class Activity_Detalle_Remesa : Activity
    {
        RemesaFamiliar temp;
        TextView txtdescp;
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DetalleRemesa);

            // Create your application here
            int id = Intent.GetIntExtra("id",0);
            temp = Global.Remesas.Where(x=>x.Id ==id).FirstOrDefault();


            txtdescp = FindViewById<TextView>(Resource.Id.textView3);
            listView = FindViewById<ListView>(Resource.Id.listView1);


            txtdescp.Text = "Año: " + temp.Annio.ToString() + "     " + "Monto Total: " + temp.total.ToString();


            List<Meses> envios = Global.Remesas.Where(c => c.Id == temp.Id).SelectMany(r => r.ListMeses).ToList();
            listView.Adapter = new AdapterCustomListDetalleRemensa(this, envios);



        }
    }
}