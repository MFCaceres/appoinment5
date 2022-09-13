using HealthCon.WebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

 var Logger = new LoggerConfiguration().MinimumLevel.Information()
    .WriteTo.File("C:\\Users\\HQ619GP\\source\\repos\\HealthCon.WebAPI\\Logs.log", 
    rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Logging.AddSerilog(Logger);


// Add services to the container.



builder.Services.AddControllers();


//builder.Logging.AddSerilog();

builder.Services.AddDbContext<DocCareOnlineContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("dbdoc")));

DocCareOnlineContext? _dbcontext = builder.Services.BuildServiceProvider().GetService<DocCareOnlineContext>();

builder.Services.AddSingleton<IRefreshTokenGenerator>(provider => new RefreshTokenGenerator(_dbcontext));


var _jwtsettings = builder.Configuration.GetSection("jwtsetting");
builder.Services.Configure<JWTSetting>(_jwtsettings);

var authkey = builder.Configuration.GetValue<string>("jwtsetting:securitykey");

builder.Services.AddAuthentication(item =>
{
    item.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    item.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(item =>
{
    item.RequireHttpsMetadata = true;
    item.SaveToken = true;
    item.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authkey)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swagger =>
{
    //this is to generate the default ui of swagger documentation    
    swagger.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "asp.net 5 web api",
        Description = "authentication and authorization in asp.net 5 with jwt and swagger"
    });
    // to enable authorization using swagger (jwt)    
    swagger.AddSecurityDefinition("bearer", new OpenApiSecurityScheme()
    {
        Name = "authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "bearer",
        BearerFormat = "jwt",
        In = ParameterLocation.Header,
        Description = "enter 'bearer' [space] and then your valid token in the text input below.\r\n\r\nexample: \"bearer eyjhbgcioijiuzi1niisinr5cci6ikpxvcj9\"",
    }
    );
    swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "bearer"
                                }
                            },
                            new string[] {}

                    }
                 }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
