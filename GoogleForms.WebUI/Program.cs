using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using GoogleForms.BLL.DependencyResolvers;
using GoogleForms.BLL.Helper;
using GoogleForms.BLL.ValidationRules;
using GoogleForms.DTOs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDependencies(builder.Configuration);
builder.Services.AddControllersWithViews();
//builder.Services.AddValidatorsFromAssemblyContaining<FormCreateDto>();


var profiles = ProfileHelper.GetProfiles();
var mapperConfiguration = new MapperConfiguration(opt =>
{
    opt.AddProfiles(profiles);
});
var mapper = mapperConfiguration.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=form}/{action=home}/{id?}"
    );
});

app.MapRazorPages();    
app.Run();
