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
    
    public partial class F_EDZES_GYAKORLAT
    {
        public int EDZES_GYAKORLAT_SK { get; set; }
        public int EDZES_ID { get; set; }
        public int GYAKORLAT_ID { get; set; }
        public Nullable<int> ISMETLES { get; set; }
        public Nullable<decimal> IDOTARTAM { get; set; }
        public Nullable<decimal> SULY { get; set; }
    
        public virtual D_GYAKORLAT D_GYAKORLAT { get; set; }
        public virtual F_EDZES F_EDZES { get; set; }
    }
}