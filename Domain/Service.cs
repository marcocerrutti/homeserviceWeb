using System;

namespace Domain;

public class Service
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsCancelled { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; } // duration in minutes

    // location props
    public required string City { get; set; }
    public required string Venue { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}
