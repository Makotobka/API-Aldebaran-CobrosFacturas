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
    
    public partial class vVenta
    {
        public int IDFV { get; set; }
        public System.DateTime Fecha { get; set; }
        public string TIPO { get; set; }
        public string Autorizacion { get; set; }
        public string Numero { get; set; }
        public string FORMAPAGO { get; set; }
        public Nullable<decimal> COMISIONPORC { get; set; }
        public Nullable<decimal> Comision { get; set; }
        public decimal SubtotalIVA { get; set; }
        public decimal SUBTOTAL0 { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DESCPORC { get; set; }
        public decimal Descuento { get; set; }
        public Nullable<decimal> SubtotalIVADesc { get; set; }
        public Nullable<decimal> SubtotalIVA0Desc { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Cambio { get; set; }
        public string ESTADO { get; set; }
        public int IDCT { get; set; }
        public string CEDRUC { get; set; }
        public string CLIENTE { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CATCLIENTE { get; set; }
        public int DETIDPD { get; set; }
        public bool DETAPLICAIVA { get; set; }
        public decimal DETIVA { get; set; }
        public string DETCODIGO { get; set; }
        public string DETITEM { get; set; }
        public decimal DETPRECIO { get; set; }
        public decimal DETCANT { get; set; }
        public decimal DETTOTAL { get; set; }
        public Nullable<decimal> DETPORCCOMISION { get; set; }
        public Nullable<decimal> DETCOMISION { get; set; }
        public decimal DETCOSTO { get; set; }
        public decimal DETPCP { get; set; }
        public int IDUS { get; set; }
        public string USUARIONOMBRE { get; set; }
        public string USUARIO { get; set; }
        public Nullable<int> IDPT { get; set; }
        public string PUNTOVENTA { get; set; }
        public string AutorizacionFA { get; set; }
        public string AutorizacionNV { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public Nullable<int> SecuenciaFA { get; set; }
        public Nullable<int> SecuenciaNV { get; set; }
        public int IDSU { get; set; }
        public string SUCURSAL { get; set; }
        public string Administrador { get; set; }
        public string SUCDIRECCION { get; set; }
        public string SUCTELEFONO { get; set; }
        public int IDCI { get; set; }
        public string CIUDAD { get; set; }
        public Nullable<int> IDEP { get; set; }
        public string VENDEDOR { get; set; }
        public decimal DESCITEM { get; set; }
    }
}
