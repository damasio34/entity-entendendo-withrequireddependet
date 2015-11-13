using System.Data.Entity.ModelConfiguration;

namespace entity_entendendo_withrequireddependet.Data.Contigurations
{
    public class PessoaTypeConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaTypeConfiguration()
        {
            // Primary Key
            HasKey(d => d.Id);

            // AS DUAS OPÇÕES FAZEM COM QUE AS CHAVES PRIMÁRIAS E ESTRANGEIRAS SEJAM AS MESMAS, 
            // OU SEJA, O ID DA PESSOA É IGUAL AO ID DO ENDEREÇO.

            // Torna obrigatório a existência de um endereço para a existencia da pessoa, 
            // Porém pode existir um endereço sem uma pessoa.

            //HasRequired(p => p.Endereco).WithRequiredDependent(p => p.Pessoa);

            // ------------------------------------------------------------------------------------------ //
            
            // Torna obritarória a existência de uma pessoa para a existência de um endereço,
            // Porém pode existir uma pessoa sem que exista um endereço.

            HasRequired(p => p.Endereco).WithRequiredPrincipal(p => p.Pessoa);
        }
    }
}
