//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciDers
    {
        public int ID { get; set; }
        public int DersID { get; set; }
        public int OgrenciID { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
