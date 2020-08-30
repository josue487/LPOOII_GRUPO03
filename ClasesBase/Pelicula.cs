using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private string peli_Codigo;
        private string peli_Titulo;
        private string peli_Duracion;
        private string peli_Genero;
        private string peli_Clase;

        public string Peli_Codigo { get => peli_Codigo; set => peli_Codigo = value; }
        public string Peli_Titulo { get => peli_Titulo; set => peli_Titulo = value; }
        public string Peli_Duracion { get => peli_Duracion; set => peli_Duracion = value; }
        public string Peli_Genero { get => peli_Genero; set => peli_Genero = value; }
        public string Peli_Clase { get => peli_Clase; set => peli_Clase = value; }
    }
}