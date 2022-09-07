using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<HttpClient>();
// void ConfigureServices(IServiceCollection services)
//{
//    services.AddRazorPages();
//    services.AddServerSideBlazor();

//    services.AddHttpClient<ICalculatorService, CalculatorService>(client =>
//    {
//        client.BaseAddress = new Uri("https://localhost:5151/");
//    });
//}

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
