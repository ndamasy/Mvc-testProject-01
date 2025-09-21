using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_4_BLL.DTO;
using G_4_BLL.Factories;
using G_4_DAL.Reposatories;

namespace G_4_BLL.DAL.Services
{
    public class DepartmentServices(IDepartmentReposatory departmentReposatory) : IDepartmentServices, IDepartmentServices
    {
        private readonly IDepartmentReposatory _departmentReposatory = departmentReposatory;

        // here we will write business logic
        //get all departments
        public IEnumerable<DepartmentsDto> GetAllDepartment()
        {
            var Departments = _departmentReposatory.GetAll();
            return Departments.Select(D => D.ToDepartmentDto());
            //manual mapping
            //var DepartmenToReturn = Departments.Select(d => new DepartmentsDto
            //{
            //    DeptId = d.DeptId,
            //    Name = d.Name,
            //    Code = d.Code,
            //    Description = d.Description,
            //    DateOfCreation = d.DateOfCreation
            //});
            //return DepartmenToReturn;
        }

        //get by id
        public DepartmentDetailsDto? GetDepartmentById(int id)
        {
            var department = _departmentReposatory.GetById(id);
            return department is null ? null : department.ToDepartmentDetailsDto();

            //if (department == null)
            //{
            //    return null;
            //}
            //var departmentToReturn = new DepartmentDetailsDto
            //{
            //    DeptId = department.DeptId,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //    DateOfCreation = department.DateOfCreation,
            //    LastModifiedBy = department.LastModifiedBy,
            //    LstModifiedOn = department.LstModifiedOn,
            //    IsDeleted = department.IsDeleted
            //};
            //return departmentToReturn;
            //return department is null? null : new DepartmentDetailsDto
            //{
            //    DeptId = department.DeptId,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //    DateOfCreation = department.DateOfCreation,
            //    LastModifiedBy = department.LastModifiedBy,
            //    LstModifiedOn = department.LstModifiedOn,
            //    IsDeleted = department.IsDeleted
            //};
        }


        // Add
        public int AddDepartment(CreatedDepartmentDto departmentDto)
        {
            var Department = departmentDto.ToEntity();
            return _departmentReposatory.Add(Department);

        }

        //Update
        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
        {
            return _departmentReposatory.Update(departmentDto.ToEntity());

        }

        //Delete
        public bool DeleteDepartment(int id)
        {
            var Department = _departmentReposatory.GetById(id);
            if (Department is null)
            {
                return false;
            }
            else
            {
                int result = _departmentReposatory.Remove(Department);
                return result > 0 ? true : false;
            }
        }
    }
}
