using System.Data.Entity.Migrations;
using entity_entendendo_withrequireddependet.Data;

namespace entity_entendendo_withrequireddependet.Migrations
{    
    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            //context.Pessoa.Add(new Pessoa {Nome = "Andrew Peters"});
        }
    }
}
