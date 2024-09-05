namespace MVC02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            //Add To Any Services U Need To The Container

            //builder.Services.AddControllers(); //Register The Built-In APIs Services in the Container
            builder.Services.AddControllersWithViews(); //Register The Built-In MVC Services in the Container
            //builder.Services.AddRazorPages(); //Register The Built-In Razor Pages Services in the Container
            //builder.Services.AddMvc(); //Register The Built-In All Web Services in the Container


            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            //app.MapGet("/Hamada", () => "Hello Hamada!");
            //app.MapGet("/Signin", Signin);

            // http://localhost:5001/Movies/GetMovie/1



            app.MapControllerRoute(
                name: "Default",
                pattern: "/{controller}/{action}/{id}"
                );



            app.Run();
        }

        static string Signin()
        {
            return "Signin";
        }
    }
}
