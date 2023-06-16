using BackendSignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(option => option.AddDefaultPolicy(policy => policy
        .AllowCredentials()
        .AllowAnyHeader()
        .AllowAnyHeader()
        .SetIsOriginAllowed(x => true)));

builder.Services.AddSignalR();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<Chat>("/chathub");
    endpoints.MapControllers();
});


//app.MapGet("/", () => "Hello World!");

app.Run();
