using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripAlbum.Data
{
    public class TripPhoto
    {
        public int TripPhotoId { get; set; }
        public string Caption { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
