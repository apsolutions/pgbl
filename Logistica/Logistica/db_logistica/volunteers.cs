//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistica.db_logistica
{
    using System;
    using System.Collections.Generic;
    
    public partial class volunteers
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public short type { get; set; }
        public short earlyArrival { get; set; }
        public short ownLeave { get; set; }
        public string allergies { get; set; }
        public string medicalCondition { get; set; }
        public string emergencyContact { get; set; }
        public string diet { get; set; }
        public string comments { get; set; }
        public string ficha { get; set; }
        public string flights { get; set; }
    
        public virtual ficha ficha1 { get; set; }
    }
}
