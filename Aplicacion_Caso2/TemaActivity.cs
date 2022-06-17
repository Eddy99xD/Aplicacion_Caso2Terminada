using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Aplicacion_Caso2.Resources.Adaptadores;
using Aplicacion_Caso2.Resources.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion_Caso2
{
    [Activity(Label = "TemaActivity")]
    public class TemaActivity : Activity
    {
        TextView descripcion;
        TextView smallDesc;
        ListView lstTemas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.contenido);

            descripcion = FindViewById<TextView>(Resource.Id.txtTitle);
            smallDesc = FindViewById<TextView>(Resource.Id.textView2);
            lstTemas = FindViewById<ListView>(Resource.Id.listView1);

            descripcion.Text = GetString(Resource.String.DescTemas);
            smallDesc.Text = GetString(Resource.String.SmallTemas);
            lstTemas.Adapter = new adtTematica(this, Contenido.temas);
        }

        private void lstTemas_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = Contenido.temas[e.Position];
            //
            Intent i = new Intent(this, typeof(VideoActivity));
            i.PutExtra("temaId", item.id);
            StartActivity(i);
        }
    }
}