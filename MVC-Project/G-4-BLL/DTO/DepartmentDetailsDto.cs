using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_4_BLL.DTO
{
    public class DepartmentDetailsDto
    {
        public int DeptId { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? DateOfCreation { get; set; } //user id
        public int LastModifiedBy { get; set; }
        public DateTime? LstModifiedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
