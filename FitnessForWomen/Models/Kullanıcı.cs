//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessForWomen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanıcı
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> UyelikBaslangıc { get; set; }
        public Nullable<System.DateTime> UyelikBitis { get; set; }
        public string Email { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public Nullable<int> EgitmenId { get; set; }
    
        public virtual Egitmenler Egitmenler { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
    }
}
