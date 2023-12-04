using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Portfolio/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Portfolio}/{action=Index}/{id?}");

app.MapControllerRoute("AboutMe", "about-me", new { controller = "Portfolio", action = "AboutMe" });
app.MapControllerRoute("Resume", "resume", new { controller = "Portfolio", action = "Resume" });
app.MapControllerRoute("Education", "education", new { controller = "Portfolio", action = "Education" });
app.MapControllerRoute("Experience", "experience", new { controller = "Portfolio", action = "Experience" });
app.MapControllerRoute("Skills", "kills", new { controller = "Portfolio", action = "Skills" });
app.MapControllerRoute("Roadmap", "roadmap", new { controller = "Portfolio", action = "Roadmap" });
app.MapControllerRoute("Projects", "projects", new { controller = "Portfolio", action = "Projects" });
app.MapControllerRoute("Contact", "contact", new { controller = "Portfolio", action = "Contact" });

app.Run();
