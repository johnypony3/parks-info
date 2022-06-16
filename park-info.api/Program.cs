using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var titleBase = "Parks API";

builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new park_info.Conventions.GroupingByNamespaceConvention());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    var description = "This is a Web API for Parks operations.";
    var TermsOfService = new Uri("https://udemy.com/user/evgeniyameshuris/");
    var License = new OpenApiLicense()
    {
        Name = "MIT"
    };

    var Contact = new OpenApiContact()
    {
        Name = "Evgeniya Meshuris",
        Email = "em@theemm.com",
        Url = new Uri("https://evm.blog/")
    };

    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = titleBase + " v1",
        Description = description,
        TermsOfService = TermsOfService,
        License = License,
        Contact = Contact
    });

    config.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = titleBase + " v2",
        Description = $"{description} and is now secured via api key.",
        TermsOfService = TermsOfService,
        License = License,
        Contact = Contact
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", titleBase + " v1");
        config.SwaggerEndpoint("/swagger/v2/swagger.json", titleBase + " v2");
    });

    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();

