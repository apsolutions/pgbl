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
    
    public partial class university
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public university()
        {
            this.ficha = new HashSet<ficha>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public short disable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ficha> ficha { get; set; }
    }
}