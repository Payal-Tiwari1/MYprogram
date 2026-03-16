var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


    app.MapGet("/home", async (HttpContext context) =>
    {  
       await context.Response.WriteAsync("This is from Get..");
    });

    app.MapPost("/home", async (HttpContext context) =>
    {
        await context.Response.WriteAsync("This is from Post..");
    });

    app.MapPut("/home", async ( HttpContext context) =>
    {
        await context.Response.WriteAsync("This is from Put..");
    });

    app.MapDelete("/home", async (HttpContext context) =>
    {
        await context.Response.WriteAsync("This is from Delete..");
    });

    app.MapFallback(async (HttpContext context) =>
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("This Page Is Not Found..");
    });


//app.Map("/", () => "Hello World!");
//app.MapGet("/home", () => "Hello World!- Get");
//app.MapPost("/home", () => "Hello World!- Post");
//app.MapPut("/home", () => "Hello World!- Put");
//app.MapDelete("/home", () => "Hello World!- Delete");




app.Run();
