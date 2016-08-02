using System;

namespace BirdingLog.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Taken { get; set; }
    }
}