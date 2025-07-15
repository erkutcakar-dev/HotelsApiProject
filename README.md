# 🏨 HotelsApiProject - Booking.com API Entegrasyon (ASP.NET 8.0 MVC)

---

## 🚀 Proje Hakkında

HotelsApiProject, *RapidAPI* üzerinden sunulan *Booking.com API* ile entegre çalışan, tamamen veritabanı kullanmadan gerçek zamanlı otel arama ve detay gösterimi sağlayan bir ASP.NET 8.0 MVC uygulamasıdır. Tüm otel, şehir ve fotoğraf verileri API'den canlı olarak çekilir ve kullanıcıya modern, responsive bir arayüzle sunulur.

---

## 🛠 Kullanılan Teknolojiler

| Teknoloji         | Açıklama                                               |
|------------------|-------------------------------------------------------|
| ⚙ ASP.NET 8.0 MVC | Modern .NET tabanlı web uygulama çatısı               |
| 🧱 Tek Katmanlı Yapı | Sade, doğrudan ve anlaşılır kod organizasyonu         |
| 🧠 ViewModel       | UI ve API veri akışında tip güvenliği ve kolaylık     |
| 🌐 RapidAPI        | Booking.com API erişimi için köprü                    |
| 🏨 Booking.com API | Otel, şehir, detay ve fotoğraf bilgileri              |
| 💎 Bootstrap 4/5   | Responsive ve modern kullanıcı arayüzü                |

---

## 📡 Kullanılan Booking API Endpoint'leri

| Endpoint                | Açıklama                                                                 |
|-------------------------|-------------------------------------------------------------------------|
| 🔍 /stays/auto-complete | Şehir adı ile yapılan aramayı şehir ID’sine dönüştürür                  |
| 🔎 /stays/search         | Şehir ID, tarih ve kişi sayısına göre otel araması yapar               |
| 🧾 /stays/detail         | Otel hakkında detaylı bilgi verir (puan, seviye, açıklama, yorum sayısı) |
| 🖼 /stays/get-photos     | Otelin yüksek çözünürlüklü görsellerini getirir                        |

---

## 🧑‍💻 Kullanıcı Akışı

### 📥 Bilgi Girişi
Kullanıcı arama formunda şu bilgileri girer:
- 📍 Şehir Adı  
- 📅 Giriş Tarihi  
- 📅 Çıkış Tarihi  
- 👤 Yetişkin Sayısı  
- 👶 Çocuk Sayısı  

### 🔄 API İşleyişi
1. 🎯 auto-complete: Girilen şehir adı şehir ID'sine çevrilir.  
2. 🔍 search: Şehir ID’si ve tarih bilgileriyle oteller aranır.  
3. 🧾 detail: Her otel için detaylı bilgiler çekilir.  
4. 🖼 get-photos: Otelin yüksek çözünürlüklü görselleri elde edilir.

---

## 🏨 Kullanıcıya Sunulan Otel Bilgileri

| Bilgi                  | Açıklama                                                                  |
|------------------------|---------------------------------------------------------------------------|
| 🖼 Otel Fotoğrafı        | En yüksek çözünürlüklü görsel seçilip gösterilir                         |
| 🏨 Otel Adı              | Booking.com üzerinde yer alan otel ismi                                   |
| ⭐ Puan                 | Otelin kullanıcılar tarafından aldığı puan                               |
| 🎖 Seviye Başlığı       | Booking.com’un puana karşılık gösterdiği değerlendirme seviyesi          |
| 📝 Değerlendirme Sayısı | Otel hakkında yapılan yorum sayısı                                       |
| 🏷 Fiyat                | API'den gelen güncel fiyat bilgisi                                       |
| 🏠 Açıklama             | Oda ve otel açıklamaları, olanaklar                                      |

> 🔄 Tüm bu veriler her aramada API üzerinden *anlık olarak çekilir*.  
> 💾 Projede *herhangi bir kalıcı veri kaynağı (veritabanı) kullanılmaz*.

---

## 🧩 Proje Yapısı ve Teknik Detaylar

- **Klasik Detay Sayfası:** Otel kartına tıklanınca ayrı bir detay sayfası açılır (modal veya AJAX ile kart içi detay yoktur).
- **ViewModel Bazlı Akış:** Tüm veri transferi ve UI, ViewModel'ler üzerinden tip güvenli şekilde yapılır.
- **Hata Yönetimi:** API'den gelen null/değişken tipli değerler için C# nullable tipler ve robust model tanımları kullanılmıştır.
- **Yüksek Çözünürlüklü Fotoğraflar:** Otel kartlarında ve detayda en büyük/best kalite görsel gösterilir.
- **Modern UI:** Bootstrap ile responsive ve şık arayüz, sade ve kullanıcı dostu deneyim.
- **Kolay Genişletilebilirlik:** Yeni endpoint veya özellik eklemek için sadece ilgili ViewModel ve Controller güncellenir.
- **Türkçe & İngilizce Açıklamalı Kod:** Kodun önemli noktalarında açıklamalar hem Türkçe hem İngilizce olarak eklenmiştir.

---

## ▶️ Projeyi Çalıştırma

1. **.NET 8 SDK** yüklü olmalı ([.NET Download](https://dotnet.microsoft.com/download))
2. Proje klasöründe terminal açın:
   ```bash
   dotnet run --project HotelsApiProject/HotelsApiProject.csproj
   ```
3. Tarayıcıda `http://localhost:5000` veya verilen portu açın.

> API anahtarınızı ve Booking.com RapidAPI bilgilerinizi `appsettings.json` dosyasına eklemeyi unutmayın!

---

## 🗂️ Proje Klasör Yapısı

```text
HotelsApiProject/
├── HotelsApiProject.sln
└── HotelsApiProject/
    ├── appsettings.json
    ├── appsettings.Development.json
    ├── Controllers/
    │   ├── HomeController.cs
    │   └── HotelController.cs
    ├── Models/
    │   ├── HotelDetailViewModel.cs
    │   ├── HotelSearchViewModel.cs
    │   ├── HotelPhotosViewModel.cs
    │   └── LocationViewModel.cs
    ├── Views/
    │   ├── Home/
    │   │   ├── Index.cshtml
    │   │   └── Privacy.cshtml
    │   ├── Hotel/
    │   │   ├── HotelDetail.cshtml
    │   │   ├── HotelList.cshtml
    │   │   └── SearchForm.cshtml
    │   └── Shared/
    │       ├── _HotelLayout.cshtml
    │       ├── _Layout.cshtml
    │       └── Components/
    ├── wwwroot/
    │   ├── css/
    │   ├── js/
    │   └── palatin-gh-pages/ (tema ve statik dosyalar)
    ├── Program.cs
    └── HotelsApiProject.csproj
```

---

## 🤝 Katkı ve Geri Bildirim

- Pull request ve issue açarak katkıda bulunabilirsiniz.
- Her türlü öneri, hata bildirimi ve geliştirme talebine açığız.
- Kodun okunabilirliği ve sürdürülebilirliği için katkı yaparken açıklama eklemeyi unutmayın.

---

## 📄 Lisans

Bu proje MIT lisansı ile lisanslanacaktır. (Lisans dosyasını eklemeyi unutmayın.)

---

## 🙌 Teşekkürler

Booking.com API ile gerçek zamanlı otel arama ve detay gösterimi için bu örnek projeyi inceleyen herkese teşekkürler! Geri bildirimleriniz bizim için çok değerli. 