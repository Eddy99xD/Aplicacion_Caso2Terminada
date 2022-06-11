using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Aplicacion_Caso2.Resources.FuenteDatos;
using Aplicacion_Caso2.Resources.Negocio;
using Aplicacion_Caso2.Resources.Adaptadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion_Caso2
{
    [Activity(Label = "VideoActivity")]
    public class VideoActivity : Activity
    {
        TextView descripcion;
        TextView smallDesc;
        ListView lstVideos;

        int temaId;
        List<Video> listaFiltrada = new List<Video>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.contenido);

            smallDesc.FindViewById<TextView>(Resource.Id.textView2);
            descripcion.FindViewById<TextView>(Resource.Id.txtDescripcion);
            lstVideos.FindViewById<ListView>(Resource.Id.listView1);

            descripcion.Text = GetString(Resource.String.DescVideos);
            smallDesc.Text = GetString(Resource.String.SmallVideos);

            temaId = Intent.GetIntExtra("TemaId", -1);
            if (temaId!=-1)
            {
                listaFiltrada = Contenido.videos.Where(x => x.tematicaid == temaId).ToList();
            }
            else
            {
                Toast.MakeText(this, "No hay Videos que mostrar", ToastLength.Long).Show();
            }
            lstVideos.Adapter = new adtVideos(this, Contenido.videos);
            lstVideos.ItemClick += lstVideos_ItemClick;
        }

        private void lstVideos_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            alerta.SetTitle("Visualizar video");
            alerta.SetIcon(Android.Resource.Drawable.IcDialogInfo);
            alerta.SetMessage("¿Desea visualizar el video acerca de " +
                listaFiltrada[e.Position].desc   + " ?");
            alerta.SetPositiveButton("Si", delegate
             {
                 string url = listaFiltrada[e.Position].url;
             });

            alerta.Show();
        }
    }
}