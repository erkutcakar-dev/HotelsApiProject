namespace HotelsApiProject.Models
{
    public class LocationViewModel
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        public class Datum
        {
            public float swLon { get; set; }
            public float swLat { get; set; }
            public string type { get; set; }
            public float neLat { get; set; }
            public float neLon { get; set; }
        }

    }
}
