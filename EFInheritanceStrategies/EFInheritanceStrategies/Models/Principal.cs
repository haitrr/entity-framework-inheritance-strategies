using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFInheritanceStrategies.Models
{
    [Table("Principal")]
    public class Principal : Teacher
    {
    }
}
