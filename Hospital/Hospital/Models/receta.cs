
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
    
public partial class receta
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public receta()
    {

        this.visita = new HashSet<visita>();

    }


    public int idReceta { get; set; }

    public Nullable<int> idPaciente { get; set; }

    public Nullable<int> idEmpleado { get; set; }

    public Nullable<System.DateTime> fechaReceta { get; set; }

    public string detalleReceta { get; set; }



    public virtual empleado empleado { get; set; }

    public virtual paciente paciente { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<visita> visita { get; set; }

}

}
