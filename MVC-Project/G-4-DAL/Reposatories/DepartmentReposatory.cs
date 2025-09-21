using G_4_DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_4_DAL.Reposatories
{
    //primary constructor .net 8
    public class IDepartmentReposatory(ApplicationDbContext DbContext) : IDepartmentReposatory
    {

        private readonly ApplicationDbContext _dbContext = DbContext; // this is method for dependency injection

        //public DepartmentReposatory(ApplicationDbContext dbContext) // inject applicationdbcontext
        //{
        //    // ask clr fro creating object from applicationdbcontext
        //    _dbContext = dbContext;
        //}
        //crud operations
        //get all departments
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _dbContext.Departments.ToList();

            }
            else
            {
                return _dbContext.Departments.AsNoTracking().ToList();
            }

        }
        //get department by id
        public Department? GetById(int id)
        {
            var Department = _dbContext.Departments.Find(id);
            return Department;
        }

        //add
        public int Add(Department department)
        {

            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }
        //update
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
        //delete
        public int Delete(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }


    }
}
