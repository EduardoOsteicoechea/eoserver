using eoserver;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();

//app.UseHttpsRedirection();

app.MapGet("", () =>
{
   string html = $@"
      <!DOCTYPE html>
      <html lang='en'>
         <head>
            <meta charset='utf-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <meta name='description' content='Test api'>                                                                                                        
            <meta name='theme-color' content='#fff'>
            <meta name='author' content='Eduardo Osteicoechea'>
            <meta name='robots' content='index,follow'>
            <link rel='stylesheet' href='index.css'>
            <link rel='icon' type='image/x-icon' href='favicon.webp'>
         </head>                                                                                                                                             
      <body>                                                                                                                                                      
         <main>
            <h1>eomserver</h1>
            <h2>We are preparing your user experience</h2>
            <h3>Please wait</h3>                                                                                                                        
         </main>                                                                                                                                             
         <script src='index.js'></script>                                                                                                            
      </body>                                                                                                                                     
      </html> 
   ";
   
   return Results.Content(html, "text/html");
});

app.MapGet("/crintt", () =>
{
   string html = new CrinttPage("Crintt.com", new CrinttPageComponents()).Print();
   
   return Results.Content(html, "text/html");
});

app.MapGet("/bimapi", () =>
{   
   return Results.Content(new BimApi().Content, "text/json");
});

app.Run();














//using eomserver;

//var builder = WebApplication.CreateBuilder(args);

//var app = builder.Build();

//app.MapGet("", () =>
//{                                                                                                                                                      return Results.Content("<h1>thanks lord</h1>", "text/html");
//});                                                                                                                                                                                                                                                                                                     app.MapGet("/crintt", () =>
//{                                                                                                                                                      string html = new CrinttPage("Crintt.com", new CrinttPageComponents()).Print();
//                                                                                                                                                       return Results.Content("hello", "text/plain");
//});                                                                                                                                                                                                                                                                                                     app.Run();