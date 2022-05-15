using ProjetoUnimed.Context;
using ProjetoUnimed.Models;

namespace ProjetoUnimed.Util
{
    public static class Seeder
    {

        public static void CarregaPessoas()
        {
            using var context = new UnimedContext();

            if (context.Pessoas.Count() == 0)
            {
                context.Pessoas.AddRange(new Pessoa[]{
                    new(){
                        Nome = "Cleberson",
                        CPF = "34523156791",
                        Nascimento = new DateTime(1998, 10, 24),
                        NomeDaMae = "Jucicleia"
                    }, new(){
                        Nome = "Fagundes",
                        CPF = "76412387365",
                        Nascimento = new DateTime(1997, 5, 13),
                        NomeDaMae = "Fagunleia"
                    }, new(){
                        Nome = "Windson",
                        CPF = "56743278920",
                        Nascimento = new DateTime(1998, 2, 23),
                        NomeDaMae = "Wind"
                    }
                });
                context.SaveChanges();
            }
        }
    }
}