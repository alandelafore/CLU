//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLU.Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class SolicitudLegitimoUsuario
    {
        public int IDSolicitudLegitimoUsuario { get; set; }
        public string CodgioSolicitudLegitimoUsuario { get; set; }
        public int IDUsuario { get; set; }
        public int DomicilioReal { get; set; }
        public int GuardaDeArmas { get; set; }
        public string CategoriaSolicitada { get; set; }
        public string CategoriaMedidasSeguridad { get; set; }
        public string NumeroCredencialAnterior { get; set; }
        public Nullable<int> IDPago { get; set; }
    
        public virtual Domicilio Domicilio { get; set; }
        public virtual Domicilio Domicilio1 { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
