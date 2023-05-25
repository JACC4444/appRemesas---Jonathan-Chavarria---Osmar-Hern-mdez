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
    class AdapterCustomListDetalleRemensa : BaseAdapter<Meses>
    {

        Activity context;
        List<Meses> items;

        public AdapterCustomListDetalleRemensa(Activity context, List<Meses> items)
        {
            this.context = context;
            this.items = items;
        }

        public override Meses this[int position] => items[position];

        public override int Count => items.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.list_item_detalleRemesas, null);

            var item = items[position];

            TextView id = view.FindViewById<TextView>(Resource.Id.textView1);
            TextView meses = view.FindViewById<TextView>(Resource.Id.textView2);
            TextView monto = view.FindViewById<TextView>(Resource.Id.textView3);

            id.Text = item.Mes.ToString();
            meses.Text = Meses(item.Mes);
            monto.Text = "$ "+ item.Monto.ToString();

            return view;


        }

        private string Meses(int i)
        {
            switch (i)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default:
                    return "Informacion Invalida";

            }

        }

    }
}