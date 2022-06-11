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

namespace Aplicacion_Caso2.Resources.FuenteDatos
{
    class Video
    {
        public Video(int id, string desc, string url, int tematicaid)
        {
            this.id = id;
            this.desc = desc;
            this.url = url;
            this.tematicaid = tematicaid;
        }

        public int id { get; set; }
        public string desc { get; set; }
        public string url { get; set; }
        public int tematicaid { get; set; }
    }
}