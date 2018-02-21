using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFInheritanceStrategies.Models
{
    [Table("Teacher")]
    public class Teacher : Person
    {
        public string TeacherId { get; set; }
        public double LicenseNumber { get; set; }
    }
}
