var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Välkommen till whiksy API.");
app.MapGet("/", () => "Här har vi en simpel API fylld med whisky's som skaparen Felix Tycker om!.");

app.Run();

namespace whiskyRestapi
{
    public class whisky
    {
        public int whiskyId {get;set;}
        public string Name {get;set;}
        public string Maker {get;set;}
        public string tasteProfile {get;set;}
        public int smokeyness {get;set;}
        public int sweetness {get;set;}
    }
}
