
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Hospital.Models
{

using System;
    using System.Collections.Generic;
    
public partial class factura
{

    public int idFactura { get; set; }

    public Nullable<int> idCita { get; set; }

    public Nullable<int> idPaciente { get; set; }

    public Nullable<System.DateTime> fecha { get; set; }

    public Nullable<int> costo { get; set; }



    public virtual cita cita { get; set; }

    public virtual paciente paciente { get; set; }

}

}
