using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public int IDNoSocio { get; set; }

        public override string ObtenerBeneficio()
        {
            return "NO SOCIO: Accede sólo a actividades asignadas";
        }
    }
}
