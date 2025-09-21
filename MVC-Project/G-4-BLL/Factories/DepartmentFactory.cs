using G_4_BLL.DTO;
using G_4_DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_4_BLL.Factories
{
    public static class DepartmentFactory
    {
        //get all
        public static DepartmentsDto ToDepartmentDto(this DepartmentsDto D)
        {
            return new DepartmentsDto
            {
                DeptId = D.DeptId,
                Name = D.Name,
                Code = D.Code,
                Description = D.Description,
                DateOfCreation = D.DateOfCreation
            };
        }

        //get by id
        public static DepartmentDetailsDto ToDepartmentDetailsDto(this Department D)
        {
            return new DepartmentDetailsDto()
            {

                DeptId = D.Id,
                Name = D.Name,
                Code = D.Code,

            };
        }
        
    //mapping for add or create

    public static Department ToEntity (this CreatedDepartmentDto D)
        {
            return new Department()
            {
                Name = D.Name,
                Code = D.Code,
                Description = D.Description,
                createOn = D.DateOfCreation
            };

        }

        //update
        public static Department ToEntity(this UpdatedDepartmentDto D)
        {
            return new Department()
            {
                Id=D.Id,
                Name = D.Name,
                Code = D.Code,
                Description = D.Description,
                createOn = D.DateOfCreation
            };

        }

    }
}

