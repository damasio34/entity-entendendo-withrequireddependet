using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using entity_entendendo_withrequireddependet.Data.Contigurations;

namespace entity_entendendo_withrequireddependet.Data
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public Context() : base("entity_entendendo") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PessoaTypeConfiguration());
            modelBuilder.Configurations.Add(new EnderecoTypeConfiguration());
        }
    }
}