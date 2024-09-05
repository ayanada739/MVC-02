using Microsoft.AspNetCore.Mvc;

namespace MVC02.NewFolder2
{
    public class MoviesController: Controller
    {
        //Actions: Public non-static Functions


        public string Test()
        {
            return "Default Path";
        }
        public string GetMovie(int id)
        {
            return $"Id: {id}";
        }

    }
}
