//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hunger.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbFOODITEM_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbFOODITEM_List()
        {
            this.dbDISTRIBUTION_List = new HashSet<dbDISTRIBUTION_List>();
            this.dbEMPLOYEE_List = new HashSet<dbEMPLOYEE_List>();
            this.dbRESTAURENT_List = new HashSet<dbRESTAURENT_List>();
            this.dbTRACKCOLLECTION_List1 = new HashSet<dbTRACKCOLLECTION_List>();
        }
    
        public int FOOD_ID { get; set; }
        public string FOODITEM_List { get; set; }
        public Nullable<int> COLLECTREQUEST_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbDISTRIBUTION_List> dbDISTRIBUTION_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbEMPLOYEE_List> dbEMPLOYEE_List { get; set; }
        public virtual dbTRACKCOLLECTION_List dbTRACKCOLLECTION_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbRESTAURENT_List> dbRESTAURENT_List { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbTRACKCOLLECTION_List> dbTRACKCOLLECTION_List1 { get; set; }
    }
}
