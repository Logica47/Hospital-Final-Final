
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
    
public partial class visita
{

    public int idVisita { get; set; }

    public Nullable<int> idEmpleado { get; set; }

    public Nullable<int> idReceta { get; set; }

    public Nullable<System.DateTime> fechaLlegada { get; set; }

    public Nullable<System.DateTime> proximaFecha { get; set; }

    public string motivo { get; set; }

    public string comentario { get; set; }



    public virtual empleado empleado { get; set; }

    public virtual receta receta { get; set; }

}

}
