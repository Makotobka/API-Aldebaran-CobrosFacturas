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
    
    public partial class Sel_Stock_Result
    {
        public int ID { get; set; }
        public string CODBARRAS { get; set; }
        public string CODEXTERNO { get; set; }
        public string PRODUCTO { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public Nullable<decimal> STOCKMINIMO { get; set; }
        public Nullable<decimal> STCKMAXIMO { get; set; }
        public Nullable<decimal> STOCKACTUAL { get; set; }
        public string ESTABLECIMIENTO { get; set; }
        public string CIUDAD { get; set; }
    }
}
