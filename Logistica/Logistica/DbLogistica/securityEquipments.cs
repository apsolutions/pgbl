//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistica.DbLogistica
{
    using System;
    using System.Collections.Generic;
    
    public partial class securityEquipments
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public short quantity { get; set; }
        public short cost { get; set; }
        public string coments { get; set; }
        public string lastModifiedBy { get; set; }
        public System.DateTime dateModified { get; set; }
    }
}
