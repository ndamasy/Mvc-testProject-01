using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_4_DAL.models
{
    public class BaseEntity
    {
public int Id { get; set; }
        public int createdBy { get; set; }
        public DateTime? createOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime? LstModifiedOn { get; set; }
        public bool IsDeleted { get; set; }


    }
}
