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
    class Tematica
    {

        public Tematica(int id,string tema)
        {
            this.id = id;
            this.tema = tema;
        }

        private int id { get; set; }
        private string tema { get; set; }
    }
}