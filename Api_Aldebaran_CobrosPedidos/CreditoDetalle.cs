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
    
    public partial class CreditoDetalle
    {
        public int ID { get; set; }
        public int IDCREDITO { get; set; }
        public string TIPO { get; set; }
        public Nullable<decimal> Bono { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public string Concepto { get; set; }
        public string Codigo { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Credito Credito { get; set; }
    }
}