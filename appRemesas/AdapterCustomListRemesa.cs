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
    class AdapterCustomListRemesa : BaseAdapter<RemesaFamiliar>
    {
        Activity context;
        List<RemesaFamiliar> items;

        public AdapterCustomListRemesa(Activity context, List<RemesaFamiliar> items)
        {
            this.context = context;
            this.items = items;
        }

        public override RemesaFamiliar this[int position] => items[position];

        public override int Count => items.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.list_item_layout, null);

            var item = items[position];

            ImageView iconImageView = view.FindViewById<ImageView>(Resource.Id.imageView1);
            TextView titleTextView = view.FindViewById<TextView>(Resource.Id.textView1);
            TextView infoTextView = view.FindViewById<TextView>(Resource.Id.textView2);

            iconImageView.SetImageResource(Resource.Drawable.Money_20px);
            titleTextView.Text = "Año: " + " " + item.Annio.ToString();
            infoTextView.Text = "Total: " + "$ " + item.total.ToString();

            return view;
        }

    }
}