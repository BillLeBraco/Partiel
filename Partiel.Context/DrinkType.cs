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
    
    public partial class DrinkType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrinkType()
        {
            this.Drinks = new HashSet<Drink>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<double> AlcoholContent { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Volume { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drink> Drinks { get; set; }
    }
}
