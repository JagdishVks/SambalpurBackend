using dharmendraPradhan;
using dharmendraPradhan.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Configure connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LocationContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<CommunityDominatesContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<PartyConditionContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusPoliticalNoteContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusResultsContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusImportantGroupsContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusCommunityPeopleContext>(options => { options.UseSqlServer(connectionString); });


//builder.Services.AddDbContext<StatusMainWorkerContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusPanchayatMembersContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusSocialMediaActContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusBoothAgentContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusGovtOfficialsWorkingContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusMainLocalDemandContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusDevelopmentWorkContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<StatusGetAllLocsContext>(options => { options.UseSqlServer(connectionString); });



builder.Services.AddDbContext<StatusMainWorkerContext>(options => { options.UseSqlServer(connectionString); });


builder.Services.AddDbContext<StatusLocalPeopleContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<StatusContactPersonContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<StatusLocalShopKeeperContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddDbContext<StatusAreaDevelopContext>(options => { options.UseSqlServer(connectionString); });
builder.Services.AddDbContext<GetLocIDAndBoothContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 

////app.MapGet("/api/location", async (LocationContext context) =>
////{
////    var location = await context.Locations.Select(l => l.Latitude ).Distinct().ToListAsync();

////});

////app.MapGet("/api/AC_Name/{pc_name}", async(String pc_name) => { });


app.UseCors("AllowAll");

app.MapControllers();



app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
