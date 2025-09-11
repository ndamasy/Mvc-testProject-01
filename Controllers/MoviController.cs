using Microsoft.AspNetCore.Mvc;

namespace Mvc_TestProject.Controllers
{
    public class MoviController:Controller
    {

        public string Index()
        {
            return "Hello from Movi Controller index";
        }
        // to get data from url u should send request contain base url/class name/method name /id
        public ContentResult GetMovi(int? Id)
        {
            ContentResult Result = new ContentResult();
            Result.Content = $"Movi with Id {Id} is Avatar";
          
            return Result;
        }
       

         
    }
}
