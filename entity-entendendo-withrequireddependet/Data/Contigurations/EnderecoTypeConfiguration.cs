using System.Data.Entity.ModelConfiguration;

namespace entity_entendendo_withrequireddependet.Data.Contigurations
{
    public class EnderecoTypeConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoTypeConfiguration()
        {
            // Primary Key
            HasKey(d => d.Id);            
        }
    }
}
