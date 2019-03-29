using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class Traveller
    {
        public int TravellerId { get; set; }
        public string TravellerName { get; set; }
        public DateTime TravellerBirthDate { get; set; }
        public string TravellerGender { get; set; }
        public int TripId { get; set; }

        public SportTrip Trip { get; set; }
    }
}
