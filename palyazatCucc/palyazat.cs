//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace palyazatCucc
{
    using System;
    using System.Collections.Generic;
    
    public partial class palyazat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public palyazat()
        {
            this.szamla = new HashSet<szamla>();
        }
    
        public int id { get; set; }
        public Nullable<int> tervezetA { get; set; }
        public Nullable<int> tervezetC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<szamla> szamla { get; set; }
    }
}
