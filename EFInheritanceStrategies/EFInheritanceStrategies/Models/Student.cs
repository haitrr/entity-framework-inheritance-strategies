using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFInheritanceStrategies.Models
{
    [Table("Student")]
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string JoinedYear { get; set; }
    }
}
