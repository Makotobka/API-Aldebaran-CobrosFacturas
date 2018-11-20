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
    
    public partial class Tarjeta
    {
        public int IDTJ { get; set; }
        public int IDSU { get; set; }
        public int IDCT { get; set; }
        public int IDFV { get; set; }
        public int IDEP { get; set; }
        public int IDST { get; set; }
        public string Codigo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Periodicidad { get; set; }
        public decimal Entrada { get; set; }
        public int NumCuotas { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string GarNombre { get; set; }
        public string GarDireccion { get; set; }
        public string GarTelefono { get; set; }
        public bool Retiro { get; set; }
        public string ObservacionesRetiro { get; set; }
        public Nullable<System.DateTime> FechaRetiro { get; set; }
        public string Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual FactVenta FactVenta { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}