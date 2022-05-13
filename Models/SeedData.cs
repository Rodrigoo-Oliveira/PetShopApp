using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PetShopApp.Models
{
    public static class SeedData
    {
        public static void Inicializar(IServiceProvider serviceProvider)
        {
            using(var context = new PetShopAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetShopAppContext>>()))
            {
                // verificar se há dados no banco
                if(context.Proprietario.Any()){
                    // há dados no banco
                }else{
                    context.Proprietario.AddRange(
                        new Proprietario
                        {
                            Nome ="Agatha Esther da Rocha",
                            Cpf ="081.878.098-33",
                            Endereco ="Rua Independência, 600",
                            Telefone ="(14) 98524-1532",
                            Email ="agatha.esther.darocha@granvale.com.br",
                            DtNascimento = DateTime.Parse("1983-04-01"),
                        },
                        new Proprietario
                        {
                            Nome ="Alana Bárbara da Luz",
                            Cpf ="268.915.928-79",
                            Endereco ="Rua Abs Yasbek, 175",
                            Telefone ="(14) 98906-8929",
                            Email ="alana-daluz97@unitau.com.br",
                            DtNascimento = DateTime.Parse("1952-02-22"),
                        },
                        new Proprietario
                        {
                            Nome ="Bárbara Antônia Aparício",
                            Cpf ="260.571.038-66",
                            Endereco ="Rua Avestil Justo Ferreira, 622",
                            Telefone ="(14) 98234-6651",
                            Email ="barbara_antonia_aparicio@dep.ufscar.br",
                            DtNascimento = DateTime.Parse("1986-01-02"),
                        },
                        new Proprietario
                        {
                            Nome ="Marcela Regina Almada",
                            Cpf ="941.568.888-27",
                            Endereco ="Rua Madre Elide Parzianello, 815",
                            Telefone ="(14) 99291-1294",
                            Email ="marcela_almada@zigotto.com.br",
                            DtNascimento = DateTime.Parse("1984-02-22"),
                        }
                    );

                }
                if(context.Produto.Any())
                {
                    // Há dados Não fazer nada
                }else{
                    context.Produto.AddRange(
                        new Produto
                        {
                            Nome = "Shampoo Dog",
                            Descricao = "Shampoo para Cachorros",
                            QuantidadeEstoque = 20,
                            PrecoCompra = 10,
                            PrecoVenda = 25,
                        },
                        new Produto
                        {
                            Nome = "Shampoo Cat",
                            Descricao = "Shampoo para Gatos",
                            QuantidadeEstoque = 15,
                            PrecoCompra = 12,
                            PrecoVenda = 20,
                        }
                    );
                }

                

                context.SaveChanges();
            }
        }
    }
}