using Cursos.Aplicaton.DI;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


// This method gets called by the runtime. Use this method to add services to the container.

Initializer.Configure(builder.Services, builder.Configuration.GetConnectionString("DefaultConnection"));
  

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.Run();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
