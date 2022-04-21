using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Student.DataAcess.EF;
using Student.WebApplication.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddControllersWithViews();
builder.Services.AddCors(option =>
{
    option.AddPolicy("CorsPolicy",
        builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        );
});

// Add services to the container.
builder.Services.AddRazorPages();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new EFModule()));
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new RepositoryModule()));
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new ServicesModule()));

builder.Services.AddDbContext<StudentManagerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentManagerConn"));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();
