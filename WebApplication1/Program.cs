using Microsoft.Extensions.DependencyInjection;
using System;
using WebApplication1.entities;
using WebApplication1.services;

var builder = WebApplication.CreateBuilder(args);
//1.1
/*var app = builder.Build();
builder.Configuration.AddJsonFile(@"data/configuration.json");
app.MapGet("/", (IConfiguration appConfig) =>
{
    Company microsoft = new Company(appConfig["Companies:Microsoft:Name"],
        Convert.ToInt32(appConfig["Companies:Microsoft:Employees"]));
    Company apple = new Company(appConfig["Companies:Apple:Name"],
        Convert.ToInt32(appConfig["Companies:Apple:Employees"]));
    Company google = new Company(appConfig["Companies:Google:Name"],
        Convert.ToInt32(appConfig["Companies:Google:Employees"]));
    string res1, res2;
    if (microsoft.Employees > apple.Employees && microsoft.Employees > google.Employees)
    {
        res1 = $"{microsoft.Name} has the most employees - {microsoft.Employees}\n";
        res2 = apple.Employees > google.Employees ?
        $"{apple.Name} is second with {apple.Employees} employees\n" +
        $"{google.Name} is third with {google.Employees} employees" :
        $"{google.Name} is second with {google.Employees} employees\n" +
        $"{apple.Name} is third with {apple.Employees} employees";

    }
    else if (apple.Employees > microsoft.Employees && apple.Employees > google.Employees)
    {
        res1 = $"{apple.Name} has the most employees - {apple.Employees}\n";
        res2 = microsoft.Employees > google.Employees ?
        $"{microsoft.Name} is second with {microsoft.Employees} employees\n" +
        $"{google.Name} is third with {google.Employees} employees" :
        $"{google.Name} is second with {google.Employees} employees\n" +
        $"{microsoft.Name} is third with {microsoft.Employees} employees";
    }
    else
    {
        res1 = $"{google.Name} has the most employees - {google.Employees}\n";
        res2 = microsoft.Employees > apple.Employees ?
        $"{microsoft.Name} is second with {microsoft.Employees} employees\n" +
        $"{apple.Name} is third with {apple.Employees} employees" :
        $"{apple.Name} is second with {apple.Employees} employees\n" +
        $"{microsoft.Name} is third with {microsoft.Employees} employees";
    }
    return $"{res1}{res2}";
});*/

//1.2
/*var app = builder.Build();
builder.Configuration.AddXmlFile(@"data/configuration.xml");
CompaniesXmlBindable companies = new CompaniesXmlBindable();
app.Configuration.Bind(companies);
app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    string res1, res2;
    if (companies.Microsoft.Employees > companies.Apple.Employees &&
    companies.Microsoft.Employees > companies.Google.Employees)
    {
        res1 = $"{companies.Microsoft.Name} has the most employees - <b>{companies.Microsoft.Employees}</b><br>";
        res2 = companies.Apple.Employees > companies.Google.Employees ?
        $"{companies.Apple.Name} is second with {companies.Apple.Employees} employees<br>" +
        $"{companies.Google.Name} is third with {companies.Google.Employees} employees" :
        $"{companies.Google.Name} is second with {companies.Google.Employees} employees<br>" +
        $"{companies.Apple.Name} is third with {companies.Apple.Employees} employees";
    }
    else if (companies.Apple.Employees > companies.Microsoft.Employees &&
    companies.Apple.Employees > companies.Google.Employees)
    {
        res1 = $"{companies.Apple.Name} has the most employees - <b>{companies.Apple.Employees}</b><br>";
        res2 = companies.Microsoft.Employees > companies.Google.Employees ?
        $"{companies.Microsoft.Name} is second with {companies.Microsoft.Employees} employees<br>" +
        $"{companies.Google.Name} is third with {companies.Google.Employees} employees" :
        $"{companies.Google.Name} is second with {companies.Google.Employees} employees<br>" +
        $"{companies.Microsoft.Name} is third with {companies.Microsoft.Employees} employees";
    }
    else
    {
        res1 = $"{companies.Google.Name} has the most employees - <b>{companies.Google.Employees}</b><br>";
        res2 = companies.Microsoft.Employees > companies.Apple.Employees ?
        $"{companies.Microsoft.Name} is second with {companies.Microsoft.Employees} employees<br>" +
        $"{companies.Apple.Name} is third with {companies.Apple.Employees} employees" :
        $"{companies.Apple.Name} is second with {companies.Apple.Employees} employees<br>" +
        $"{companies.Microsoft.Name} is third with {companies.Microsoft.Employees} employees";
    }
    await context.Response.WriteAsync($"{res1}{res2}");
});*/

//1.3
/*var app = builder.Build();
builder.Configuration.AddIniFile(@"data/configuration.ini");
app.MapGet("/", (IConfiguration appConfig) =>
{
    Company microsoft = new Company(appConfig["Microsoft:name"],
        Convert.ToInt32(appConfig["Microsoft:employees"]));
    Company apple = new Company(appConfig["Apple:name"],
        Convert.ToInt32(appConfig["Apple:employees"]));
    Company google = new Company(appConfig["Google:name"],
        Convert.ToInt32(appConfig["Google:employees"]));
    string res1, res2;
    if (microsoft.Employees > apple.Employees && microsoft.Employees > google.Employees)
    {
        res1 = $"{microsoft.Name} has the most employees - {microsoft.Employees}\n";
        res2 = apple.Employees > google.Employees ?
        $"{apple.Name} is second with {apple.Employees} employees\n" +
        $"{google.Name} is third with {google.Employees} employees" :
        $"{google.Name} is second with {google.Employees} employees\n" +
        $"{apple.Name} is third with {apple.Employees} employees";

    }
    else if (apple.Employees > microsoft.Employees && apple.Employees > google.Employees)
    {
        res1 = $"{apple.Name} has the most employees - {apple.Employees}\n";
        res2 = microsoft.Employees > google.Employees ?
        $"{microsoft.Name} is second with {microsoft.Employees} employees\n" +
        $"{google.Name} is third with {google.Employees} employees" :
        $"{google.Name} is second with {google.Employees} employees\n" +
        $"{microsoft.Name} is third with {microsoft.Employees} employees";
    }
    else
    {
        res1 = $"{google.Name} has the most employees - {google.Employees}\n";
        res2 = microsoft.Employees > apple.Employees ?
        $"{microsoft.Name} is second with {microsoft.Employees} employees\n" +
        $"{apple.Name} is third with {apple.Employees} employees" :
        $"{apple.Name} is second with {apple.Employees} employees\n" +
        $"{microsoft.Name} is third with {microsoft.Employees} employees";
    }
    return $"{res1}{res2}";
});*/

//2
var app = builder.Build();
builder.Configuration.AddJsonFile(@"data/info.json");
Person me = new Person();
app.Configuration.Bind(me);
app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    string name = $"<p style=\"color:orange; font-size:30px\">{me.Name} {me.Surname}</p>";
    string age = $"<p>Age: <b>{me.Age}</b> years old<p>";
    string ethnicity = $"<p>Ethnicity/Citizenship: <b style=\"color:orange\">{me.Ethnicity}</b></p>";
    await context.Response.WriteAsync($"{name}{age}{ethnicity}");
});

app.Run();
