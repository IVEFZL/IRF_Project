//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FittSoft
{
    using System;
    using System.Collections.Generic;
    
    public partial class D_KATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public D_KATEGORIA()
        {
            this.D_GYAKORLAT = new HashSet<D_GYAKORLAT>();
        }
    
        public int KATEGORIA_SK { get; set; }
        public string MEGNEVEZES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_GYAKORLAT> D_GYAKORLAT { get; set; }
    }
}
