//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternshipsManagmentProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.StudentInternships = new HashSet<StudentInternship>();
            this.Skills = new List<string>();
        }
    
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string University { get; set; }
        public string Domain { get; set; }
        public string Bio { get; set; }
        public System.DateTime Birthday { get; set; }
        public string LevelOfStudies { get; set; }
        public Nullable<bool> Available { get; set; }
        public string StudentCV { get; set; }

        //Da are si userul din asp mi-e lene sa-l iau de acolo. Serios? Da nu vreau FIGHT ME !!! 
        public string PhoneNumber { get; set; }
        public string LinkGithub { get; set; }
        public string City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<string> Skills { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Resume Resume { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentInternship> StudentInternships { get; set; }
    }
}
