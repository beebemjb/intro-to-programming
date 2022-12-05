var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/break/{minutes:int}", (int minutes) =>
{ 
    var response = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        DateTime.Now.AddMinutes(minutes)
        );
    return Results.Ok(response);
});

app.Run();

public record BreakTimerResponse(int minutes, DateTime StartTime, DateTime EndTime);
