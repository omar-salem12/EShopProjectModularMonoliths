
var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddCatalogModule(builder.Configuration)
       .AddBasketModule(builder.Configuration)
      .AddOrderingModule(builder.Configuration);
var app = builder.Build();

//Configure a http middleware pipeline

app.UseBasketModule()
   .UseCatalogModule()
   .UseOrderingModule();

app.Run();
