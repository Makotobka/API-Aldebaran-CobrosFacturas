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
    
    public partial class TarjetaHabiente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TarjetaHabiente()
        {
            this.DevTHabiente = new HashSet<DevTHabiente>();
            this.THDetalle = new HashSet<THDetalle>();
        }
    
        public int IDTH { get; set; }
        public int IDCT { get; set; }
        public int IDVH { get; set; }
        public int IDSU { get; set; }
        public int IDPT { get; set; }
        public int IDUS { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Numero { get; set; }
        public string FormaPago { get; set; }
        public Nullable<decimal> PorcentajeComision { get; set; }
        public Nullable<decimal> Comision { get; set; }
        public decimal SubtotalIVA { get; set; }
        public decimal SubtotalIVA0 { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevTHabiente> DevTHabiente { get; set; }
        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THDetalle> THDetalle { get; set; }
    }
}
