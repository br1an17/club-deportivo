using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class E_Socio : E_Cliente
    {
        public int NroAfiliado { get; set; }
        public string? EstadoSocio { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public override string ObtenerBeneficio()
        {
            return "SOCIO: Accede a todas las actividades";
        }
    }
}
