//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Aldebaran_CobrosPedidos
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoRubro
    {
        public int IDRE { get; set; }
        public int IDEP { get; set; }
        public int IDRB { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Rubro Rubro { get; set; }
    }
}