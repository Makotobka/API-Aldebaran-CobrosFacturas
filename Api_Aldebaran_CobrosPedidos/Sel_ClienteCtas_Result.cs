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
    
    public partial class Sel_ClienteCtas_Result
    {
        public int IDCTA { get; set; }
        public int IDCT { get; set; }
        public string Nombre { get; set; }
        public string CEDRUC { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public decimal Cupo { get; set; }
        public decimal SALDO { get; set; }
        public string DetalleCta { get; set; }
    }
}
