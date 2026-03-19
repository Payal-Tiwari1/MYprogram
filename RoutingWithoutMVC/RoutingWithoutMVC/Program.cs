var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name:"default",
//    pattern: "{controller=Home}/{action=Index}/{id?}"
//    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=About}/{id?}"
    );                                                  //Conventional based routing. The route template "{controller=Home}/{action=About}/{id?}" defines a default route where the controller is "Home", the action is "About", and the "id" parameter is optional. This means that if a request does not specify a controller or action, it will default to "Home" and "About". For example, if you access the root URL ("/"), it will route to the "About" action of the "HomeController". If you access "/User/Index", it will route to the "Index" action of the "UserController". If you access "/User/Details/5", it will route to the "Details" action of the "UserController" with an "id" parameter of 5.

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=User}/{action=Index}/{id?}"
//    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=About}/{id?}"
    );


app.MapControllers();                   //Atribute based routing. This method enables attribute routing, which allows you to define routes directly on your controller actions using attributes. For example, in the "HomeController", you can use the [Route] attribute to specify the route for each action method. This provides more flexibility and control over the routing of your application.

app.Run();
