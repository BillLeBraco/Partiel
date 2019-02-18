//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Partiel.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Association
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Association()
        {
            this.Events = new HashSet<Event>();
            this.Members = new HashSet<Member>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> PresidentId { get; set; }
        public double Fees { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipPostalCode { get; set; }
        public int SchoolId { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Member> Members { get; set; }
    }
}