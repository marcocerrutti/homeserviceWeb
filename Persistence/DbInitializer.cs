using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeeData(AppDbContext context)
    {
        if (context.Services.Any()) return;
        var services = new List<Service>
        {
            new Service
            {
                Name = "Women's Haircut and Styling",
                Description = "Haircut & styling at customer’s home by professional stylist",
                IsCancelled = false,
                Price = 20.00m,
                Date = DateTime.UtcNow,
                Duration = 60,
                City = "Lagos",
                Venue = "Customer's Home",
                Latitude = 6.5244,
                Longitude = 3.3792
            },
            new Service
            {
                Name = "Facial & Skincare Treatment",
                Description = "Deep cleansing facial with herbal packs, anti-aging treatments",
                IsCancelled = false,
                Price = 35.00m,
                Date = DateTime.UtcNow.AddMonths(1),
                Duration = 60,
                City = "Abuja",
                Venue = "Customer's Home",
                Latitude = 9.0765,
                Longitude = 7.3986
            },
            new Service
            {
                Name = "Full Body Massage",
                Description = "Relaxing full body massage with essential oils, provided at home",
                IsCancelled = false,
                Price = 50.00m,
                Date = DateTime.UtcNow.AddDays(2),
                Duration = 120,
                City = "Port Harcourt",
                Venue = "Customer's Home",
                Latitude = 4.8156,
                Longitude = 7.0498
            },
            new Service
            {
                Name = "3-Seater Sofa Deep Cleaning",
                Description = "Foam wash and vacuum cleaning for fabric and leather sofas",
                IsCancelled = false,
                Price = 45.00m,
                Date = DateTime.UtcNow.AddDays(2),
                Duration = 90,
                City = "Lagos",
                Venue = "Customer's Home",
                Latitude = 6.4654,
                Longitude = 3.4064
            },
              new Service
            {
                Name = "AC Repair and Servicing",
                Description = "Gas refill, cleaning, and minor repairs for split/window AC units",
                IsCancelled = false,
                Price = 55.00m,
                Date = DateTime.UtcNow.AddMonths(1),
                Duration = 120,
                City = "Abuja",
                Venue = "Customer's Home",
                Latitude = 9.0578,
                Longitude = 7.4951
            },
                new Service
                {
                    Name = "Washing Machine Repair",
                    Description = "Fixing leaks, drainage issues, and motor problems for all brands",
                    IsCancelled = false,
                    Price = 40.00m,
                    Date = DateTime.UtcNow.AddMonths(2),
                    Duration = 90,
                    City = "Kano",
                    Venue = "Customer's Home",
                    Latitude = 12.0022,
                    Longitude = 8.5919
                },
                new Service
                {
                    Name = "Plumbing Services",
                    Description = "Fixing leaks, unclogging drains, and installing fixtures at home",
                    IsCancelled = false,
                    Price = 30.00m,
                    Date = DateTime.UtcNow.AddDays(3),
                    Duration = 60,
                    City = "Ibadan",
                    Venue = "Customer's Home",
                    Latitude = 7.3775,
                    Longitude = 3.9470
                },
                new Service
                {
                    Name = "Electrical Repairs",
                    Description = "Fixing wiring issues, installing switches, and troubleshooting faults",
                    IsCancelled = false,
                    Price = 35.00m,
                    Date = DateTime.UtcNow.AddDays(5),
                    Duration = 90,
                    City = "Benin City",
                    Venue = "Customer's Home",
                    Latitude = 6.3382,
                    Longitude = 5.6258
                },
                new Service
                {
                    Name = "Home Cleaning Service",
                    Description = "Comprehensive home cleaning including dusting, mopping, and sanitizing",
                    IsCancelled = false,
                    Price = 25.00m,
                    Date = DateTime.UtcNow.AddDays(1),
                    Duration = 120,
                    City = "Lagos",
                    Venue = "Customer's Home",
                    Latitude = 6.5244,
                    Longitude = 3.3792
                },
                new Service
                {
                    Name = "Lawn Mowing and Gardening",
                    Description = "Lawn mowing, hedge trimming, and basic garden maintenance services",
                    IsCancelled = false,
                    Price = 30.00m,
                    Date = DateTime.UtcNow.AddDays(4),
                    Duration = 90,
                    City = "Abeokuta",
                    Venue = "Customer's Home",
                    Latitude = 7.1530,
                    Longitude = 3.3615
                }

        };
        context.Services.AddRange(services);
        await context.SaveChangesAsync();
    }
}
