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
    
    public partial class tbl_qthdr
    {
        public int id { get; set; }
        public string qthdr_rev { get; set; }
        public Nullable<int> qthdr_qn_basis { get; set; }
        public string qthdr_name { get; set; }
        public Nullable<int> qthdr_acct_id { get; set; }
        public string qthdr_lang_id { get; set; }
        public Nullable<int> qthdr_amu { get; set; }
        public string qthdr_memo { get; set; }
        public string qthdr_instr { get; set; }
        public Nullable<System.DateTime> qthdr_date { get; set; }
        public Nullable<System.DateTime> qthdr_date_update { get; set; }
        public Nullable<int> qthdr_rep_id { get; set; }
        public Nullable<int> qthdr_cs_qty { get; set; }
        public string qthdr_HS_code { get; set; }
        public Nullable<int> qthdr_plant_id { get; set; }
        public Nullable<int> qthdr_brand_id { get; set; }
        public Nullable<int> qthdr_formula_id { get; set; }
        public Nullable<bool> qthdr_sterility { get; set; }
        public string qthdr_sterility_mthd { get; set; }
        public Nullable<int> qthdr_sell_crncy { get; set; }
        public Nullable<int> qthdr_box_id { get; set; }
        public Nullable<int> qthdr_status_id { get; set; }
        public Nullable<System.DateTime> qthdr_status_date { get; set; }
        public string qthdr_fg_num { get; set; }
        public Nullable<int> qthdr_fg_rev { get; set; }
        public Nullable<bool> qthdr_lock { get; set; }
        public Nullable<double> qthdr_mar { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    }
}