Metodo: public IActionResult  => startUp.cs

Service.addMvc();

nuget: microsoft.mvc

app.UseMvc(routes => 
{
    routes.MapRoute(
        name: "default",
        template: "{controller}/{action}");
});

Ver tema: ASPNET Core MVC Features

Add folder Controllers

Add class => HomeController : Controller => Using de Microsoft.Mvc

public IActionResult Index(){
    return Content("Hello ASPNET Core")  //RSharper
}

Expression body member

public IActionResult Index() => Content("Hello ASPNET Core");