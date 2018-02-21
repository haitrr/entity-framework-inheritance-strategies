using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFInheritanceStrategies.Models
{
    [Table("Person")]
    public abstract class Person : Entity
    {
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
