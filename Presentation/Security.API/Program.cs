using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Security.Presention;
using Security.Persistence;
using MediatR;
using Security.Domain.Entities.Identity;
using Security.Persistence.Context;
using Security.Application.Services.AppServices;
using Security.Persistence.Services.AppServices;

var builder = WebApplication.CreateBuilder(args);


// presentation katmanýnda controller tanýmlamak için
builder.Services.AddControllers()
    .AddApplicationPart(typeof(AssemblyReference).Assembly);
//user role 
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>(); 

builder.Services.AddTransient<IBranchService,BranchService>();

//Mediatr library import
builder.Services.AddMediatR(typeof(Security.Application.AppAssemblyReference).Assembly);
builder.Services.AddAutoMapper(typeof(Security.Persistence.MyAssemblyReference).Assembly);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    var jwtSecuritySheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put ** _only_** your jwt bearer token",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };
    setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);
    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {jwtSecuritySheme,Array.Empty<string>() }
    });
});

var env = builder.Environment;
builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
builder.Services.AddPersistenceLayerService(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
