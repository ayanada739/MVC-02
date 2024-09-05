using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace MVC02.NewFolder2
{
    public class MoviesController: Controller
    {
        //Actions: Public non-static Functions
        //Actions Has special Data Types [Action Result]


        //public string Test()
        //{
        //    return "Default Path";
        //}
        //public string GetMovie(int id)
        //{
        //    return $"Id: {id}";
        //}

        [HttpGet]
        [ActionName(name: "Hamada")]


        public IActionResult GetMovie(int? id , string name , MoviesController movie
             )
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Id: {id}";
            ////result.ContentType = "text/html";
            ////result.ContentType = "object/pdf";
            //return result;

            return Content(content: $"Id: {id}" , contentType: "text/html");
        }

        // Action Parameters Binding:
        //1. Form
        //2. Segment
        //3. Query String / Query Params
        //4. File

        //public IActionResult Test(int? id)
        //{
        //    if (id is null)
        //    {
        //        //RedirectResult result = new RedirectResult(url: " https://www.facebook.com/");
        //        //return result;

        //        return Redirect(url: " https://www.facebook.com/");
        //    }
        //    else
        //    {
        //        //RedirectToActionResult result = new RedirectToActionResult(actionName: "GetMovie", controllerName: "Movies", new { id = "Hamada" });
        //        //return result;

        //        return RedirectToAction(actionName: "GetMovie", controllerName: "Movies", new { id = "Hamada" });
        //    }

            
        //}

        //public RedirectResult Test01(int? id)
        //{
        //    RedirectResult result;
        //    if (id==1)
        //    {
        //        result = new RedirectResult(url: " https://www.facebook.com/");
        //    }
        //    else
        //    {
        //        result = new RedirectResult(url: " https://www.google.com/");
        //    }

        //    return result;
        //}

    }
}
