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
    
    public partial class ProductoUnidad
    {
        public int ID { get; set; }
        public int IDItem { get; set; }
        public int IDUnidad { get; set; }
        public decimal Fracciones { get; set; }
        public string CodBarras { get; set; }
        public bool Inventario { get; set; }
        public bool Compra { get; set; }
        public bool Venta { get; set; }
        public decimal PVP { get; set; }
        public decimal PVM { get; set; }
        public bool Estado { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Unidad Unidad { get; set; }
    }
}