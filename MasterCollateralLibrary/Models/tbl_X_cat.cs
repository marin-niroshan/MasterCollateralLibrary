//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterCollateralLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_X_cat
    {
        public int cat_comp_id { get; set; }
        public int cat_cat1_id_old { get; set; }
        public int cat_cat2_id { get; set; }
        public int ID { get; set; }
        public int cat_cat1_id { get; set; }
    
        public virtual tbl_cat1 tbl_cat1 { get; set; }
        public virtual tbl_cat2 tbl_cat2 { get; set; }
        public virtual tbl_comp tbl_comp { get; set; }
    }
}
