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
    
    public partial class MovInvDet
    {
        public int IDMO { get; set; }
        public int IDPD { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal StockActual { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public string Tipo { get; set; }
    
        public virtual MovInvCab MovInvCab { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
