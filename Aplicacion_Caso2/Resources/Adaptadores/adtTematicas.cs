using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Aplicacion_Caso2.Resources.FuenteDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion_Caso2.Resources.Adaptadores
{
    internal class adtTematica : BaseAdapter<Tematica>
    {
        Activity context;
        List<Tematica> tematicas;

        public adtTematica(Activity context, List<Tematica> tematicas)
        {
            this.context = context;
            this.tematicas = tematicas;
        }

        public override Tematica this[int position]
        { get { return tematicas[position]; } }

        public override int Count
        { get { return tematicas.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = tematicas[position];

            View view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.adtContenido, null);
            }

            view.FindViewById<TextView>(Resource.Id.txtDescripcion).Text = item.id   + " - " + item.tema;

            if (item.id == 1)
                view.FindViewById<ImageView>(Resource.Id.imgVideo).SetImageResource(Resource.Drawable.python);
            else
                if (item.id == 2)
                view.FindViewById<ImageView>(Resource.Id.imgVideo).SetImageResource(Resource.Drawable.database);
            else
                view.FindViewById<ImageView>(Resource.Id.imgVideo).SetImageResource(Resource.Drawable.networking);

            return view;
        }
    }
}