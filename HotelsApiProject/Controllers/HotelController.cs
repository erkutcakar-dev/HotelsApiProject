using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using HotelsApiProject.Models;

namespace HotelsApiProject.Controllers
{
    public class HotelController : Controller
    {
        private const string APIKEY = "6f34f1fd84msh1928134c0765d35p1f3127jsn2dd4d98c36cb"; 
        private const string APIHOST = "booking-com18.p.rapidapi.com";

        public IActionResult SearchForm()
        {
            return View(); // Views/Hotel/SearchForm.cshtml
        }

        [HttpPost]
        public async Task<IActionResult> Result(string query, string checkinDate, string checkoutDate, int adults, int children)
        {
            var locationId = await GetLocationId(query);
            if (locationId == null)
                return View("Error", "Konum bulunamadı");

            var searchResult = await GetHotelSearchResults(locationId, checkinDate, checkoutDate, adults, children);
            ViewBag.CheckinDate = checkinDate;
            ViewBag.CheckoutDate = checkoutDate;

            return View("HotelList", searchResult.data); // Model: HotelSearchViewModel.Datum[]
        }

        public async Task<IActionResult> Detail(int hotelId, string checkinDate, string checkoutDate)
        {
            var detail = await GetHotelDetail(hotelId, checkinDate, checkoutDate);
            return View("HotelDetail", detail.data); // Model: HotelDetailViewModel.Data
        }

        // ---- RapidAPI çağrıları ----

        private async Task<string> GetLocationId(string query)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/auto-complete?query={query}"),
                Headers =
                {
                    { "x-rapidapi-key", APIKEY },
                    { "x-rapidapi-host", APIHOST }
                }
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(body);
            return json?.data?[0]?.id;
        }

        private async Task<HotelSearchViewModel.Rootobject> GetHotelSearchResults(string locationId, string checkinDate, string checkoutDate, int adults, int children)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/search?locationId={locationId}&checkinDate={checkinDate}&checkoutDate={checkoutDate}&adults={adults}&children={children}&units=metric&temperature=c"),
                Headers =
                {
                    { "x-rapidapi-key", APIKEY },
                    { "x-rapidapi-host", APIHOST }
                }
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<HotelSearchViewModel.Rootobject>(body);
        }

        private async Task<HotelDetailViewModel.Rootobject> GetHotelDetail(int hotelId, string checkinDate, string checkoutDate)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/detail?hotelId={hotelId}&checkinDate={checkinDate}&checkoutDate={checkoutDate}&units=metric"),
                Headers =
                {
                    { "x-rapidapi-key", APIKEY },
                    { "x-rapidapi-host", APIHOST }
                }
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<HotelDetailViewModel.Rootobject>(body);
        }

        private async Task<HotelPhotosViewModel.Rootobject> GetHotelPhotos(int hotelId)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/get-photos?hotelId={hotelId}"),
                Headers =
                {
                    { "x-rapidapi-key", APIKEY },
                    { "x-rapidapi-host", APIHOST }
                }
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<HotelPhotosViewModel.Rootobject>(body);
        }
    }
}
