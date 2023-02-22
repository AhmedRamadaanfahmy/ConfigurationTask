using taskApis.Models;
using Microsoft.EntityFrameworkCore;
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
    builder =>
    {
        builder.WithOrigins(
                            "http://localhost:4200"
                            )
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});
// builder.Services.AddCors(c =>  
// {  
//     c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());  
// });
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy(name: MyAllowSpecificOrigins,
//                       policy  =>
//                       {
//                           policy.WithOrigins("http://localhost:4200");
//                       });
// });
// using (var scope = builder.Services.CreateScope())
// {
//     using (var appContext = scope.ServiceProvider.GetRequiredService<MapConfigurationContext>())
//     {
//         appContext.Database.Migrate();
//     }
// }
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MapConfigurationContext>(
    (option) => option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(MyAllowSpecificOrigins);

//app.UseCors(options => options.AllowAnyOrigin());  

app.UseCors("AllowAngularOrigins");

app.UseHttpsRedirection();

app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
