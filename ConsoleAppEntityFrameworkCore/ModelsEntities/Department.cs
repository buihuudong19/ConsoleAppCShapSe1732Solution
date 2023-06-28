using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEntityFrameworkCore.ModelsEntities
{
    [Keyless]
    public partial class Department
    {
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
    }
}
