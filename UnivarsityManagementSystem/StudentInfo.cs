
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace UnivarsityManagementSystem
{

using System;
    using System.Collections.Generic;
    
public partial class StudentInfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public StudentInfo()
    {

        this.SectionStudents = new HashSet<SectionStudent>();

    }


    public int ID { get; set; }

    public string StudentName { get; set; }

    public string StudentPass { get; set; }

    public System.DateTime DOB { get; set; }

    public string Email { get; set; }

    public string UserType { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SectionStudent> SectionStudents { get; set; }

}

}