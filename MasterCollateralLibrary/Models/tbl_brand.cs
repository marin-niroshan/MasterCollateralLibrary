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
    
    public partial class tbl_brand
    {
        public int id { get; set; }
        public string brand_name { get; set; }
        public string brand_location { get; set; }
        public byte[] brand_logo { get; set; }
        public string brand_address1 { get; set; }
        public string brand_address2 { get; set; }
        public string brand_tel { get; set; }
        public string brand_city { get; set; }
        public string brand_state { get; set; }
        public string brand_zip { get; set; }
        public string brand_country { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}