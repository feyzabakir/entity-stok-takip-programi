//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJE_2.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class URUNLER
    {
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string URUNMARKA { get; set; }
        public Nullable<int> URUNKATEGORI { get; set; }
        public Nullable<decimal> URUNFIYAT { get; set; }
        public Nullable<int> URUNSTOK { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual CATEGORIES CATEGORIES { get; set; }
        public virtual SATISLAR SATISLAR { get; set; }
        public string RESIM { get; internal set; }
    }
}