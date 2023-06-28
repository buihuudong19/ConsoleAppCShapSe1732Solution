using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEntityFrameworkCore.ModelsEntities
{
   
    public partial class Employee
    {
        [Key]
        public int? EmpId { get; set; }
        [StringLength(50)]
        public string? FullName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dob { get; set; }
        public int? DepartmentId { get; set; }
        public int? WorkingDay { get; set; }
        public double? SalaryRate { get; set; }
    }
}
