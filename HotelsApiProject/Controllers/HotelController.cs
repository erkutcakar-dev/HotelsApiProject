using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using HotelsApiProject.Models;
using static HotelsApiProject.Models.HotelDetailViewModel;

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
            if (string.IsNullOrEmpty(locationId) || locationId == "0")
                return View("Error", "Konum bulunamadı veya geçersiz.");

            DateTime checkin, checkout;
            if (!DateTime.TryParse(checkinDate, out checkin) || !DateTime.TryParse(checkoutDate, out checkout))
                return View("Error", "Tarih formatı hatalı.");

            string apiCheckin = checkin.ToString("yyyy-MM-dd");
            string apiCheckout = checkout.ToString("yyyy-MM-dd");

            var searchResult = await GetHotelSearchResults(locationId, apiCheckin, apiCheckout, adults, children);
            ViewBag.CheckinDate = apiCheckin;
            ViewBag.CheckoutDate = apiCheckout;

            var highResPhotos = new Dictionary<int, string>();
            foreach (var hotel in searchResult.data)
            {
                var photos = await GetHotelPhotos(hotel.id.ToString());
                if (photos != null && photos.Count > 0)
                {
                    hotel.CoverImageURL = photos.First().ImageUrl;
                }
                else if (hotel.photoUrls != null && hotel.photoUrls.Length > 0)
                {
                    hotel.CoverImageURL = hotel.photoUrls[0]; // yedek: düşük kalite
                }
                highResPhotos[hotel.id] = hotel.CoverImageURL;
            }
            ViewBag.HighResPhotos = highResPhotos;

            return View("HotelList", searchResult.data); // Model: HotelSearchViewModel.Datum[]
        }


        //public async Task<IActionResult> Detail(int hotelId, string checkinDate, string checkoutDate)
        //{
        //    var detail = await GetHotelDetail(hotelId, checkinDate, checkoutDate);
        //    var photos = await GetHotelPhotos(hotelId); // List<string>
        //    ViewBag.Photos = photos;
        //    return View("HotelDetail", detail.data); // Model: HotelDetailViewModel.Data
        //}

        // AJAX ile otel detayını JSON olarak dönen action
        [HttpGet]
        public async Task<IActionResult> GetHotelDetailsJson(int hotelId, string checkinDate, string checkoutDate)
        {
            var detail = await GetHotelDetail(hotelId, checkinDate, checkoutDate);
            return Json(detail.data); // Sadece detay modelini JSON olarak döner
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

        public async Task<List<HotelPhotosViewModel>> GetHotelPhotos(string hotelId)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/get-photos?hotelId={hotelId}"),
                Headers =
          {
      { "x-rapidapi-key", APIKEY },
      { "x-rapidapi-host", APIHOST },
          },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var data = JsonConvert.DeserializeObject<dynamic>(body);

            var photos = new List<HotelPhotosViewModel>();
            try
            {
                var photoData = data?.data?.data?[hotelId];
                if (photoData != null && photoData.Count > 0)
                {
                    var firstItem = photoData[0];
                    var fourthIndex = firstItem[4];
                    var photoUrl = fourthIndex[31]?.ToString();

                    if (!string.IsNullOrEmpty(photoUrl))
                    {
                        var fullPhotoUrl = $"{data?.data?.url_prefix}{photoUrl}";

                        photos.Add(new HotelPhotosViewModel
                        {
                            ImageUrl = fullPhotoUrl
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fotoğraf alma işlemi sırasında hata oluştu: {ex.Message}");
            }
            return photos;
        }
    }
}

