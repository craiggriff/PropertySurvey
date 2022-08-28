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

app.MapPost("/SendSurveyHeader", (Header survey_header, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if(survey_header.Id==0)
        db.Add(survey_header);
    else
        db.Update(survey_header);
    db.SaveChanges();
    return_record.DBId = survey_header.Id;
    return_record.comments = "Success";

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyPanel", (PanelTable survey_panel, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if(survey_panel.Id==0)
        db.Add(survey_panel);
    else
        db.Update(survey_panel);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_panel.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyAlum", (AlumTable survey_alum, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_alum.Id == 0)
        db.Add(survey_alum);
    else
        db.Update(survey_alum);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_alum.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyBifold", (BifoldTable survey_bifold, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_bifold.Id == 0)
        db.Add(survey_bifold);
    else
        db.Update(survey_bifold);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_bifold.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyComp", (CompositeTable survey_comp, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_comp.Id == 0)
        db.Add(survey_comp);
    else
        db.Update(survey_comp);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_comp.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyCons", (ConsTable survey_cons, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_cons.Id == 0)
        db.Add(survey_cons);
    else
        db.Update(survey_cons);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_cons.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyGar", (GarageTable survey_gar, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_gar.Id == 0)
        db.Add(survey_gar);
    else
        db.Update(survey_gar);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_gar.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyGlass", (GlassTable survey_glass, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_glass.Id == 0)
        db.Add(survey_glass);
    else
        db.Update(survey_glass);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_glass.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyGreen", (GreenTable survey_green, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_green.Id == 0)
        db.Add(survey_green);
    else
        db.Update(survey_green);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_green.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyLock", (LockingTable survey_lock, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_lock.Id == 0)
        db.Add(survey_lock);
    else
        db.Update(survey_lock);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_lock.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyTimber", (TimberTable survey_timb, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_timb.Id == 0)
        db.Add(survey_timb);
    else
        db.Update(survey_timb);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_timb.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.MapPost("/SendSurveyUPVC", (UPVCTable survey_upvc, PropertySurveyServiceContext db) =>
{
    OKRecordDTO return_record = new OKRecordDTO();

    if (survey_upvc.Id == 0)
        db.Add(survey_upvc);
    else
        db.Update(survey_upvc);
    db.SaveChanges();
    return_record.comments = "Success";
    return_record.DBId = survey_upvc.Id;

    return Task.FromResult(Results.Ok(return_record));
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Jobs}/{action=Index}/{id?}");

app.Run();
