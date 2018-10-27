using System;

namespace CSharpMvcGoogleMapWithMarkers.Mvc.Models
{
    public class StoreViewModel
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
    }
}