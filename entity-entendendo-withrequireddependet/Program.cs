using System;
using System.Linq;
using entity_entendendo_withrequireddependet.Data;

namespace entity_entendendo_withrequireddependet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var endereco = new Endereco
                {
                    Logradouro = "Est. do Campinho, 687",
                    Estado = "Rio de Janeiro",
                    Cidade = "Rio de Janeiro"
                };
                var pessoa = new Pessoa { Id = Guid.NewGuid(), Nome = "Andrew Peters", Endereco = endereco };


                db.Pessoa.Add(pessoa);
                //db.Endereco.Add(endereco);

                db.SaveChanges();
            }

            using (var db = new Context())
            {
                Console.WriteLine(db.Pessoa.First().Nome);
                Console.WriteLine(db.Endereco.First().Logradouro);

                Console.ReadKey();
            } 
        }
    }
}
