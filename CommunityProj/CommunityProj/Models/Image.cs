using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityProj.Models
{
    public class Image
    {

        public Image(string route, string desc)
        {
            Route = route;
            Description = desc;

        }
        public string Route { get; set; }
        public string Description { get; set; }
    

    }
}