//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace DeAutos.Automation.Model.Database
{
    public partial class Reporting
    {
        public string Nombre_Reporte { get; set; }
        public string Nombre_SP { get; set; }
        public string To { get; set; }
        public string Asunto { get; set; }
        public string Hora_Envio { get; set; }
        public Nullable<DateTime> Ultimo_Envio { get; set; }
        public Nullable<int> Umbral { get; set; }
    }
}
