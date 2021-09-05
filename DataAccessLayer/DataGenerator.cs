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
                if (context.Casas.Any())
                {
                    return;   
                }

                context.Casas.AddRange(
                    new Casa
                    {
                        Id = 1,
                        Nombre = "Candy Land"
                        
                    },
                    new Casa
                    {
                        Id = 2,
                        Nombre = "Sorry!",
                    });

                context.SaveChanges();
            }
        }


    }
}
