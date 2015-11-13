using System;

namespace entity_entendendo_withrequireddependet
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
