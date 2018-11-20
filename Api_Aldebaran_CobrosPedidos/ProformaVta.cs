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
    
    public partial class ProformaVta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProformaVta()
        {
            this.ProformaVtaDet = new HashSet<ProformaVtaDet>();
        }
    
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDSucursal { get; set; }
        public int IDPtoVta { get; set; }
        public int IDUsuario { get; set; }
        public System.DateTime Fecha { get; set; }
        public string FormaPago { get; set; }
        public string Numero { get; set; }
        public int Secuencial { get; set; }
        public decimal SubtotalIVA { get; set; }
        public decimal SubtotalIVA0 { get; set; }
        public decimal Subtotal { get; set; }
        public decimal PorcentajeDesc { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubtotalIVADesc { get; set; }
        public decimal SubtotalIVA0Desc { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaVtaDet> ProformaVtaDet { get; set; }
    }
}
