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
    
    public partial class ProformaVtaDet
    {
        public int IDProforma { get; set; }
        public int IDProducto { get; set; }
        public int Linea { get; set; }
        public bool AplicaIVA { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PVP { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal Costo { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public string Tipo { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual ProformaVta ProformaVta { get; set; }
    }
}
