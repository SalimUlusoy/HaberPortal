//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberPortal.Database.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Uye()
        {
            this.tbl_Begeni = new HashSet<tbl_Begeni>();
            this.tbl_Paylasildi = new HashSet<tbl_Paylasildi>();
            this.tbl_Yorum = new HashSet<tbl_Yorum>();
        }
    
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Eposta { get; set; }
        public string Parola { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Yetki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Begeni> tbl_Begeni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Paylasildi> tbl_Paylasildi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Yorum> tbl_Yorum { get; set; }
    }
}