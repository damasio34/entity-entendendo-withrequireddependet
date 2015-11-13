using System;

namespace entity_entendendo_withrequireddependet
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
