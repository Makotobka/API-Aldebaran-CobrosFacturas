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
    
    public partial class ClienteCtaDetalle
    {
        public int IDDCTA { get; set; }
        public int IDCTA { get; set; }
        public string Tipo { get; set; }
        public string Concepto { get; set; }
        public decimal Bono { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Detalle { get; set; }
    
        public virtual ClienteCta ClienteCta { get; set; }
    }
}
