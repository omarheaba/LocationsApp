using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavbarAnimation.Maui.Models
{
    public class LocationModel
    {
        public string LocationName { get; set; }
        public double LocationRating { get; set; } = 0;
        public string LocationAddress { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public string FavoriteIcon { get; set; } = "outline_star.png";
    }
}
