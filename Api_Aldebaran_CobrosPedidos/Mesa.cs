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
    
    public partial class Mesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesa()
        {
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDSU { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string EstadoMesa { get; set; }
        public string Estado { get; set; }
        public string InsUsuario { get; set; }
        public string InsPC { get; set; }
        public System.DateTime InsFecha { get; set; }
        public string UpdUsuario { get; set; }
        public string UpdPC { get; set; }
        public Nullable<System.DateTime> UpdFecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
