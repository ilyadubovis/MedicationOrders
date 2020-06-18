using Microsoft.EntityFrameworkCore;
using System;

namespace MedicationOrders.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(order =>
            {
                order.HasData(
                    new
                    {
                        Id = 12345,
                        Date = new DateTime(2020, 4, 2),
                    });

                order.OwnsOne<Provider>(order => order.Provider).HasData(
                    new 
                    {
                        Id = 1,
                        Name = "Dr. Collins",
                        OrderId = 12345
                    });

                order.OwnsOne<Patient>(order => order.Patient).HasData(
                    new
                    {
                        Id = 1,
                        FirstName = "Kim",
                        LastName = "Wise",
                        StreetAddress = "1234 8th St.",
                        City = "Tampa",
                        State = "FL",
                        ZipCode = "33606",
                        OrderId = 12345
                    });

                order.OwnsMany<OrderItem>(order => order.Items).HasData(
                    new
                    {
                        Id = 1,
                        Name = "Collagen Dressing",
                        DaysSupply = 30,
                        Quantity = 30,
                        Frequency = "Every Day",
                        OrderId = 12345
                    },
                    new
                    {
                        Id = 2,
                        Name = "Collagen Powder",
                        DaysSupply = 30,
                        Quantity = 30,
                        Frequency = "Every Day",
                        OrderId = 12345
                    },
                     new
                     {
                         Id = 3,
                         Name = "WaterProof Tape",
                         DaysSupply = 30,
                         Quantity = 1,
                         Frequency = "Every Day",
                         OrderId = 12345
                     });
            });

            modelBuilder.Entity<Order>(order =>
            {
                order.HasData(
                    new
                    {
                        Id = 23986,
                        Date = new DateTime(2020, 4, 7),
                    });

                order.OwnsOne<Provider>(order => order.Provider).HasData(
                    new
                    {
                        Id = 2,
                        Name = "Dr. Williams",
                        OrderId = 23986
                    });

                order.OwnsOne<Patient>(order => order.Patient).HasData(
                    new
                    {
                        Id = 2,
                        FirstName = "Elvin",
                        LastName = "Sharvill",
                        StreetAddress = "567 Gulf Ave.",
                        City = "Tampa",
                        State = "FL",
                        ZipCode = "33609",
                        OrderId = 23986
                    });

                order.OwnsMany<OrderItem>(order => order.Items).HasData(
                    new
                    {
                        Id = 10,
                        Name = "Collagen Dressing",
                        DaysSupply = 30,
                        Quantity = 30,
                        Frequency = "Every Day",
                        OrderId = 23986
                    },
                     new
                     {
                         Id = 11,
                         Name = "Botox",
                         DaysSupply = 30,
                         Quantity = 4,
                         Frequency = "Once A Week",
                         OrderId = 23986
                     });
            });

            modelBuilder.Entity<Order>(order =>
            {
                order.HasData(
                    new
                    {
                        Id = 76543,
                        Date = new DateTime(2020, 4, 25),
                    });

                order.OwnsOne<Provider>(order => order.Provider).HasData(
                    new
                    {
                        Id = 3,
                        Name = "Dr. Schwarz",
                        OrderId = 76543
                    });

                order.OwnsOne<Patient>(order => order.Patient).HasData(
                    new
                    {
                        Id = 3,
                        FirstName = "Roman",
                        LastName = "Kutepov",
                        StreetAddress = "123 North Ave.",
                        City = "Chicago",
                        State = "IL",
                        ZipCode = "60606",
                        OrderId = 76543
                    });

                order.OwnsMany<OrderItem>(order => order.Items).HasData(
                    new
                    {
                        Id = 20,
                        Name = "Collagen Dressing",
                        DaysSupply = 30,
                        Quantity = 30,
                        Frequency = "Every Day",
                        OrderId = 76543
                    },
                     new
                     {
                         Id = 21,
                         Name = "Essential Oils",
                         DaysSupply = 60,
                         Quantity = 2,
                         Frequency = "Once A Day",
                         OrderId = 76543
                     });
            });

            modelBuilder.Entity<Order>(order =>
            {
                order.HasData(
                    new
                    {
                        Id = 81276,
                        Date = new DateTime(2020, 5, 15),
                    });

                order.OwnsOne<Provider>(order => order.Provider).HasData(
                    new
                    {
                        Id = 4,
                        Name = "Dr. Brown",
                        OrderId = 81276
                    });

                order.OwnsOne<Patient>(order => order.Patient).HasData(
                    new
                    {
                        Id = 4,
                        FirstName = "Ariana",
                        LastName = "Barros",
                        StreetAddress = "9865 Collins Blvd.",
                        City = "Sanny Isles",
                        State = "FL",
                        ZipCode = "34566",
                        OrderId = 81276
                    });

                order.OwnsMany<OrderItem>(order => order.Items).HasData(
                    new
                    {
                        Id = 30,
                        Name = "Collagen Mask",
                        DaysSupply = 30,
                        Quantity = 1,
                        Frequency = "Every Day",
                        OrderId = 81276
                    },
                     new
                     {
                         Id = 31,
                         Name = "Essential Oils",
                         DaysSupply = 30,
                         Quantity = 2,
                         Frequency = "Once A Day",
                         OrderId = 81276
                     });
            });

            modelBuilder.Entity<Order>(order =>
            {
                order.HasData(
                    new
                    {
                        Id = 99088,
                        Date = new DateTime(2020, 5, 22),
                    });

                order.OwnsOne<Provider>(order => order.Provider).HasData(
                    new
                    {
                        Id = 5,
                        Name = "Dr. Green",
                        OrderId = 99088
                    });

                order.OwnsOne<Patient>(order => order.Patient).HasData(
                    new
                    {
                        Id = 5,
                        FirstName = "Hans",
                        LastName = "Hedman",
                        StreetAddress = "12 Collins Blvd.",
                        City = "Miami Beach",
                        State = "FL",
                        ZipCode = "34567",
                        OrderId = 99088
                    });

                order.OwnsMany<OrderItem>(order => order.Items).HasData(
                    new
                    {
                        Id = 40,
                        Name = "Collagen Mask",
                        DaysSupply = 30,
                        Quantity = 1,
                        Frequency = "Every Day",
                        OrderId = 99088
                    },
                     new
                     {
                         Id = 41,
                         Name = "Essential Oils",
                         DaysSupply = 30,
                         Quantity = 2,
                         Frequency = "Once A Day",
                         OrderId = 99088
                     });
            });
        }
    }
}
