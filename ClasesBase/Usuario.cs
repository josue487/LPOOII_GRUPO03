﻿namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Contraseña;
        private string usu_ApellidoNombre;
        private string rol_Codigo;



        public int Usu_ID { get => usu_ID; set => usu_ID = value; }
        public string Usu_NombreUsuario { get => usu_NombreUsuario; set => usu_NombreUsuario = value; }
        public string Usu_Contraseña { get => usu_Contraseña; set => usu_Contraseña = value; }
        public string Usu_ApellidoNombre { get => usu_ApellidoNombre; set => usu_ApellidoNombre = value; }
        public string Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }
    }
}
