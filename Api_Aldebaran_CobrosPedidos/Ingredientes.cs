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
    
    public partial class Ingredientes
    {
        public int ID { get; set; }
        public int IDINGREDIENTE { get; set; }
        public int IDPLATILLO { get; set; }
        public decimal Cantidad { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Producto Producto1 { get; set; }
    }
}