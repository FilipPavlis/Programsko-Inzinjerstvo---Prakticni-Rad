//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KindergartenJoy
{
    using System;
    using System.Collections.Generic;
    
    public partial class aktivnost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aktivnost()
        {
            this.korisnik1 = new HashSet<korisnik>();
        }
    
        public int aktivnost_id { get; set; }
        public Nullable<int> korisnik_id { get; set; }
        public string opis { get; set; }
        public System.DateTime vrijeme { get; set; }
        public string naziv { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisnik1 { get; set; }
    }
}
