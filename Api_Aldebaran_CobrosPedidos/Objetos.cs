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
    
    public partial class Objetos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Objetos()
        {
            this.Permisos = new HashSet<Permisos>();
        }
    
        public int IDOB { get; set; }
        public Nullable<int> IDSubModulo { get; set; }
        public string Ensamblado { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public Nullable<bool> Ejecutable { get; set; }
        public Nullable<short> Orden { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual SubModulo SubModulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permisos> Permisos { get; set; }
    }
}