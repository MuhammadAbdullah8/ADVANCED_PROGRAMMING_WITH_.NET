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
    
    public partial class NGO_RESTAURENT
    {
        public int ID { get; set; }
        public Nullable<int> NG_ID { get; set; }
        public Nullable<int> RS_ID { get; set; }
    
        public virtual dbNGO_List dbNGO_List { get; set; }
        public virtual dbRESTAURENT_List dbRESTAURENT_List { get; set; }
    }
}