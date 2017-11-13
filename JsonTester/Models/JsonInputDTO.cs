using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonTester.Models
{
    //class that corresponds to required JSON structure
    public class JsonInputDTO
    {
        public List<PayloadDTO> payload { get; set; } //is a list of class PlatLoadDTO
        public int skip { get; set; }
        public int take { get; set; }
        public string totalRecords { get; set; }
    }
}