namespace PetShop.Migrations
{
    using PetShop.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetShop.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetShop.Models.PetDBContext context)
        {
            context.Pets.AddOrUpdate(i => i.Name,
                new Pet
                {
                    Name = "Scottish Fold",
                    Description = "These are pretty cute cats!",
                    DateReceived = DateTime.Parse("1989-1-11"),
                    Quantity = 4,
                    Price = 400.00M
                },

                 new Pet
                 {
                     Name = "Sphynx",
                    Description = "These cats are kind of cool!",
                    DateReceived = DateTime.Parse("1989-1-11"),
                    Quantity = 7,
                    Price = 200.00M
                 },

                 new Pet
                 {
                     Name = "Shiba Inu",
                    Description = "These are pretty cute dogs!",
                    DateReceived = DateTime.Parse("1989-1-11"),
                    Quantity = 2,
                    Price = 400.00M
                 },

               new Pet
               {
                   Name = "White Labrador",
                    Description = "These are pretty cute dogs!",
                    DateReceived = DateTime.Parse("1989-1-11"),
                    Quantity = 9,
                    Price = 200.00M
               }
           );

        }
    }
}
