//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaceTimeManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Split
    {
        public int ID { get; set; }
        public Nullable<int> BibNumber { get; set; }
        public Nullable<int> RaceID { get; set; }
        public Nullable<decimal> SplitDistance { get; set; }
        public string SplitUnits { get; set; }
        public Nullable<System.DateTime> SplitTime { get; set; }
    
        public virtual RaceEntry RaceEntry { get; set; }
    }
}
