using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tshirt.Core.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }

        public bool IsNew { get { return 0 == Id; } }
    }
}
