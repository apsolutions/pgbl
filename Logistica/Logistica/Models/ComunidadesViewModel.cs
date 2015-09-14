using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logistica.Models
{
    public class ComunidadesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int ComMembers { get; set; }
        public bool Disable { get; set; } 
    }
}