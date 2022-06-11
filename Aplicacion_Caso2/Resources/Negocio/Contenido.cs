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

namespace Aplicacion_Caso2.Resources.Negocio
{
    class Contenido
    {
        public static List<Tematica> temas = new List<Tematica>()
        {
            new Tematica(1,"Programación"),
            new Tematica(2,"Bases de Datos"),
            new Tematica(3,"Seguridad Informatica")
        };

        public static List<Video> videos = new List<Video>()
        {
            new Video(1, "Phyton - Video 1","https://rb.gy/iujybv",1),
            new Video(2, "Phyton - Introducción","https://rb.gy/7jlegv",1),
            new Video(3, "Phyton - Sintaxis","https://rb.gy/7jlegv",1),
            new Video(4, "MongoDB - ¿Qué es?","https://rb.gy/q0d6ky",2),
            new Video(5, "MongoDB - Instalación","https://rb.gy/q0d6ky",2),
            new Video(6, "Introducción a las redes"," https://rb.gy/vseis2",3),
            new Video (7, "Topologias de redes","https://rb.gy/5twued",3)
        };
    }
}