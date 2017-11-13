using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTester.Models
{
    public class PayloadDTO
    {
        public string country { get; set; }
        public string description { get; set; }
        public bool drm { get; set; }
        public int episodeCount { get; set; }
        public string genre { get; set; }
        public ImageDTO image { get; set; }
        public string language { get; set; }
        public NextEpisodeDTO nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public List<SeasonsDTO> seasons { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string tvChannel { get; set; }
    }
}