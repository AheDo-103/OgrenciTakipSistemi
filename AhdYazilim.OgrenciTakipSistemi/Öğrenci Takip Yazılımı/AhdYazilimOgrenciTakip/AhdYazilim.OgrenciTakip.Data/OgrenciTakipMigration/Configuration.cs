using AhdYazilim.OgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace AhdYazilim.OgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}