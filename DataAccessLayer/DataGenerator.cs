using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiDbContext>>()))
            {
                LoadCasas(context);
                LoadAspirante(context);
            }
        }

        private static void LoadCasas(ApiDbContext context)
        {
            if (context.Casas.Any())
            {
                return;
            }

            context.Casas.AddRange(
                new Casa
                {
                    Id = 1,
                    Nombre = "Gryffindor"

                },
                new Casa
                {
                    Id = 2,
                    Nombre = "Hufflepuff"

                },
                new Casa
                {
                    Id = 3,
                    Nombre = "Ravenclaw"

                },
                new Casa
                {
                    Id = 4,
                    Nombre = "Slytherin",
                });

            context.SaveChanges();
        }

        private static void LoadAspirante(ApiDbContext context)
        {
            if (context.Aspirantes.Any())
            {
                return;
            }

            context.Aspirantes.AddRange(
               new Aspirante
               {
                   Id = 0,
                   Nombre = "Merlin",
                   Apellido = "Magia",
                   Identificacion = 0,
                   Edad = 99,
                   IdCasa = 1
                   
               });

            context.SaveChanges();

        }
    }
}
