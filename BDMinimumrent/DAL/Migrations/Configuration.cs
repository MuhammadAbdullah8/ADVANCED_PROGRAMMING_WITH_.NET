namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.BDMinimumrentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.BDMinimumrentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            for (int i = 1; i <= 10; i++)
            {
                context.Adminhotelrents.AddOrUpdate(new Models.Adminhotelrent
                {
                    HotelName = "Hotel-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    Hoteltype = "General"
                });
            }

            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                context.Adminhotelinfos.AddOrUpdate(new Models.Adminhotelinfo
                {
                    id = i,
                    info = Guid.NewGuid().ToString().Substring(0, 5),
                    Hoteldescription = Guid.NewGuid().ToString(),
                    Datetime = DateTime.Now,
                    Hotelpostinfo = "Hotel-" + random.Next(1, 11),


                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.Adminhotelreviews.AddOrUpdate(new Models.Adminhotelreview
                {
                    id = i,
                    review = Guid.NewGuid().ToString().Substring(0, 5),
                    hotelpostinfoid = random.Next(1, 21),
                    time = DateTime.Now,
                    reviewinfo = "Hotel-" + random.Next(1, 11),
                    reviewdby = "user" + i,

                });

            }

        }
    }
}
