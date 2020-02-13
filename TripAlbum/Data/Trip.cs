using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAlbum.Data
{
    public class Trip
    {
        public int TripId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Transportation { get; set; }
        public string Details { get; set; }

        public List<TripPhoto> TripPhotos { get; } = new List<TripPhoto>();
    }
}
