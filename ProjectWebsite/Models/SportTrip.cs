using System;
using System.Collections.Generic;

namespace ProjectWebsite.Models
{
    public partial class SportTrip
    {
        public SportTrip()
        {
            Booking = new HashSet<Booking>();
            Excursion = new HashSet<Excursion>();
            Traveller = new HashSet<Traveller>();
        }

        public int TripId { get; set; }
        public string TripName { get; set; }
        public string TripTransport { get; set; }
        public int TripDuration { get; set; }
        public DateTime TripDate { get; set; }
        public bool AllowChildren { get; set; }
        public float TripPrice { get; set; }
        public int MinParticipants { get; set; }
        public int MaxParticipants { get; set; }

        public ICollection<Booking> Booking { get; set; }
        public ICollection<Excursion> Excursion { get; set; }
        public ICollection<Traveller> Traveller { get; set; }
    }
}
