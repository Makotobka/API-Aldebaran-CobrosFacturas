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
    
    public partial class PuntoVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PuntoVenta()
        {
            this.AperturaCaja = new HashSet<AperturaCaja>();
            this.CtasCobrar = new HashSet<CtasCobrar>();
            this.CtasPagar = new HashSet<CtasPagar>();
            this.DevTHabiente = new HashSet<DevTHabiente>();
            this.DevVenta = new HashSet<DevVenta>();
            this.FactCompra = new HashSet<FactCompra>();
            this.FactVenta = new HashSet<FactVenta>();
            this.FactVenta1 = new HashSet<FactVenta>();
            this.FlujoDinero = new HashSet<FlujoDinero>();
            this.ProformaVta = new HashSet<ProformaVta>();
            this.Pedido = new HashSet<Pedido>();
            this.RetencionC = new HashSet<RetencionC>();
            this.RetencionV = new HashSet<RetencionV>();
            this.TarjetaHabiente = new HashSet<TarjetaHabiente>();
        }
    
        public int IDPT { get; set; }
        public int IDSU { get; set; }
        public string Nombre { get; set; }
        public string AutorizacionFA { get; set; }
        public string AutorizacionNV { get; set; }
        public string AutorizacionNC { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public int SecuenciaFA { get; set; }
        public int SecuenciaNV { get; set; }
        public int SecuenciaNC { get; set; }
        public string AutorizacionRT { get; set; }
        public Nullable<int> SecuenciaRT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AperturaCaja> AperturaCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtasCobrar> CtasCobrar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtasPagar> CtasPagar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevTHabiente> DevTHabiente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevVenta> DevVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactCompra> FactCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactVenta> FactVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactVenta> FactVenta1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlujoDinero> FlujoDinero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaVta> ProformaVta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetencionC> RetencionC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetencionV> RetencionV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarjetaHabiente> TarjetaHabiente { get; set; }
    }
}
