namespace HotelsApiProject.Models
{
    public class HotelPhotosViewModel
    {

        public class Rootobject
        {
            public Data data { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        public class Data
        {
            public string __typename { get; set; }
            public Data1 data { get; set; }
            public string[] data_columns { get; set; }
            public string data_key { get; set; }
            public string url_prefix { get; set; }
            public object available_rooms { get; set; }
        }

        public class Data1
        {
            public object[][] _10702871 { get; set; }
        }

    }
}
