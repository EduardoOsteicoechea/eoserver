using eoserver;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
   options.AddDefaultPolicy(
       builder =>
       {
          builder
         .AllowAnyOrigin()
         .AllowAnyMethod()
	 .AllowAnyHeader();
       });
});

WebApplication app = builder.Build();

app.UseCors();
app.UseStaticFiles();

//app.MapGet("/", () =>
//{
//   Passage passage = new Passage("john.3.16","God is good");
//   return Results.Ok(passage);
//});

//app.MapGet("/api", () =>
//{
//   Passage passage = new Passage("john.3.16","God is good");
//   return Results.Ok(passage);
//});

//app.MapGet("/bible", ()=>
//{
//   Passage passage = new Passage("john.3.16","God is good");
//   return Results.Ok(passage);
//});

app.MapGet("/api/bible", () =>
{
   Passage passage = new Passage("john.3.16","God is good");
   return Results.Ok(passage);
});

app.MapGet("/api/ui/content/home", () => {
	IUIJsonContent uIJsonContent = new HomeUIJsonContent();
	return Results.Ok(uIJsonContent);
});

app.MapGet("/api/ui/content/bim", (int? companyId, int? projectId, int? checklistId)=>{
	IUIJsonContent uIJsonContent = new BimCompanyProjectBepChecklist(companyId, projectId, checklistId);
	return Results.Ok(uIJsonContent.ClientData);	
});

app.Run();
