namespace rsiProj1.Migrations
{
    using rsiProj1.Models;
    using rsiProj1.Utils.DateTimeUtils;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<rsiProj1.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "rsiProj1.DataContext";
        }

        protected override void Seed(rsiProj1.DataContext context)
        {
            var typ1 = new Type { Name = "Koncert" };
            var typ2 = new Type { Name = "Wydarzenie sportowe" };
            var typ3 = new Type { Name = "Wydarzenie kulturalne" };
            var typ4 = new Type { Name = "Wydarzenie polityczne" };
            
            context.Types.AddOrUpdate(t => t.Name, typ1);
            context.Types.AddOrUpdate(t => t.Name, typ2);
            context.Types.AddOrUpdate(t => t.Name, typ3);
            context.Types.AddOrUpdate(t => t.Name, typ4);

            var ev1 = new Event { Name = "Super koncert 1", Description = "To bêdzie super mega koncert", Date = DateTimeUtils.FromTimeStamp(1514818740), Type = typ1 };
            var ev2 = new Event { Name = "Kolejny koncert 1", Description = "Kolejny raz koncert", Date = DateTimeUtils.FromTimeStamp(1515393723), Type = typ1 };
            var ev3 = new Event { Name = "Bieganie w ko³o", Description = "Bieganie w ko³o", Date = DateTimeUtils.FromTimeStamp(1517646303), Type = typ2 };
            var ev4 = new Event { Name = "Kulturalne wydarzenie 1", Description = "Kulturalne wydarzenie 1", Date = DateTimeUtils.FromTimeStamp(1519034821), Type = typ3 };
            var ev5 = new Event { Name = "Spotkanie z pos³em wilkiem", Description = "Spotkanie z pos³em wilkiem odbêdzie siê", Date = DateTimeUtils.FromTimeStamp(1519866000), Type = typ4 };
            var ev6 = new Event { Name = "Spotkanie z pos³em zaj¹cem", Description = "Spotkanie z pos³em zaj¹cem odbêdzie siê", Date = DateTimeUtils.FromTimeStamp(1519872000), Type = typ4 };
            var ev7 = new Event { Name = "Zespó³ pieœni i tañca xxx", Description = "Zespó³ pieœni i tañca xxx zagra na rynku", Date = DateTimeUtils.FromTimeStamp(1521388800), Type = typ1 };
            var ev8 = new Event { Name = "Bieganie tam i z powrotem", Description = "Bieganie tam i z powrotem", Date = DateTimeUtils.FromTimeStamp(1522828800), Type = typ2 };
            var ev9 = new Event { Name = "Kulturalne wydarzenie 222", Description = "Kulturalne wydarzenie 222", Date = DateTimeUtils.FromTimeStamp(1523694600), Type = typ3 };
            var ev10 = new Event { Name = "Prezydent wyg³asza przemówienie", Description = "Prezydent wyg³asza przemówienie", Date = DateTimeUtils.FromTimeStamp(1525422600), Type = typ4 };
            var ev11 = new Event { Name = "Koncert charytatywny", Description = "Koncert na cele charytatywne", Date = DateTimeUtils.FromTimeStamp(1526113800), Type = typ1 };
            var ev12 = new Event { Name = "Bieganie w ko³o ty³em", Description = "Bieganie w ko³o ty³em", Date = DateTimeUtils.FromTimeStamp(1526661000), Type = typ1 };

            context.Events.AddOrUpdate(e => e.Name, ev1, ev2, ev3, ev4, ev5, ev6, ev7, ev8, ev9, ev10, ev11, ev12);
        }
    }
}
