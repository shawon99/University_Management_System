
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
    
public partial class Course
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Course()
    {

        this.Sections = new HashSet<Section>();

        this.StudentRegistrations = new HashSet<StudentRegistration>();

        this.TeacherRegistrations = new HashSet<TeacherRegistration>();

    }


    public int ID { get; set; }

    public string course_name { get; set; }

    public int course_credit { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Section> Sections { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<StudentRegistration> StudentRegistrations { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TeacherRegistration> TeacherRegistrations { get; set; }

}

}
