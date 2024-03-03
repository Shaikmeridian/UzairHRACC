using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRACCPortal.ObjectModel
{
    public class EmployeesObjectModel
    {
       
            public string IndianTimeNow = (TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"))).ToString();
            public DateTime todaydate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time")).Date;

            //employees
            
            public int EmployeesIdPK { get; set; }
            [Required(ErrorMessage = "Please enter employee name.")]
            public string EmployeesName { get; set; }
            [Required(ErrorMessage = "Please enter phone number.")]
            public string EmployeesContactPhone { get; set; }
            [Required(ErrorMessage = "Please enter email id.")]
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