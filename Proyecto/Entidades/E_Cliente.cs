using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class E_Cliente
    {
        public int NCliente {  get; set; }
        public string? NombreC { get; set; }
        public string? ApellidoC { get; set; }
        public string? TDocC { get; set; }
        public int DocC {  get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool EsSocio { get; set; }
        public bool Apto { get; set; }

        public virtual string ObtenerBeneficio()
        {
            return "";
        }

    }
}
