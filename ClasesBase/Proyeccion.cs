using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private int proy_Codigo;
        private string proy_Fecha;
        private string proy_Hora;
        private string proy_NroSala;
        private string peli_Codigo;

        public int Proy_Codigo { get => proy_Codigo; set => proy_Codigo = value; }
        public string Proy_Fecha { get => proy_Fecha; set => proy_Fecha = value; }
        public string Proy_Hora { get => proy_Hora; set => proy_Hora = value; }
        public string Proy_NroSala { get => proy_NroSala; set => proy_NroSala = value; }
        public string Peli_Codigo { get => peli_Codigo; set => peli_Codigo = value; }
    }
}