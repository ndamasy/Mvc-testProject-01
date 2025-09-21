using G_4_BLL.DAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class DepartmentController(IDepartmentServices departmentServices) : Controller
    {
      public IActionResult Index()
        {
            return View();

        }


    }
}
