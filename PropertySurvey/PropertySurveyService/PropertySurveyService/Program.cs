using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PropertySurveyService.Data;
using PropertySurveyService.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PropertySurveyServiceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PropertySurveyServiceContext") ?? throw new InvalidOperationException("Connection string 'PropertySurveyServiceContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Get Surveys
app.MapPost("/GetSurveyJobs", (GetSurveysDTO gs, PropertySurveyServiceContext db) =>
{
    List<JobDTO> send_jobs = new List<JobDTO>();

    foreach (var j in db.Job.Where(x => x.Surveyor.SurveyorCode == gs.SurveyorCode).ToList())
    {
        Customer? c = db.Customer.FirstOrDefault(x => x.CustomerId == j.CustomerId);
        
        if (c == null)
            c = new Customer();

        send_jobs.Add(new JobDTO(j,c));
    }

    return Task.FromResult(Results.Ok(send_jobs));
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Jobs}/{action=Index}/{id?}");

app.Run();
