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
    
    public partial class tbl_pix
    {
        public Nullable<int> pix_com_id { get; set; }
        public string pix_desc { get; set; }
        public byte[] pix_pix { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
        public int id { get; set; }
    
        public virtual tbl_comp tbl_comp { get; set; }
    }
}