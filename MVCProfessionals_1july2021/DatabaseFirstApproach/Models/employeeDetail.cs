//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstApproach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> EmpSalary { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public bool Status { get; set; }
    }
}
