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
    
    public partial class ImpuestoRetencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImpuestoRetencion()
        {
            this.Producto = new HashSet<Producto>();
            this.Producto1 = new HashSet<Producto>();
        }
    
        public int ID { get; set; }
        public int IDImpuesto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoSRI { get; set; }
        public decimal Porcentaje { get; set; }
        public bool PersonaNatural { get; set; }
        public bool PersonaJuridica { get; set; }
        public bool Bienes { get; set; }
        public bool Servicios { get; set; }
        public bool Otros { get; set; }
        public bool Estado { get; set; }
    
        public virtual Impuesto Impuesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto1 { get; set; }
    }
}
