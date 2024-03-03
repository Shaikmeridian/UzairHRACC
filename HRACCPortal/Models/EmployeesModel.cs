using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRACCPortal.Models
{
    public class EmployeesModel
    {
        
        public int EmployeesIdPK { get; set; }
        public string EmployeesName { get; set; }
        public string EmployeesContactPhone { get; set; }
        public string EmployeesContactEmail { get; set; }
        public string EmployeesContactAddress1 { get; set; }
        public string EmployeesContactAddress2 { get; set; }
        public string EmployeesContactCity { get; set; }
        public string EmployeesContactState { get; set; }
        public string EmployeesContactZip { get; set; }
        public string DateAdded { get; set; }
        public string DateUpdated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}