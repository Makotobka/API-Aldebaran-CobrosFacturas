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
    
    public partial class CtasPagar
    {
        public int IDCP { get; set; }
        public int IDSU { get; set; }
        public Nullable<int> IDPT { get; set; }
        public int IDFC { get; set; }
        public int IDUS { get; set; }
        public System.DateTime Fecha { get; set; }
        public string FormaPago { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public bool Estado { get; set; }
    
        public virtual FactCompra FactCompra { get; set; }
        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}