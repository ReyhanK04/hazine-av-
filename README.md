# Hazine Avı (Treasure Hunt) - 2D Grid Based Game

[cite_start]Bu proje, **Kocaeli Üniversitesi Bilgisayar Mühendisliği Programlama Laboratuvarı II** dersi kapsamında geliştirilmiştir[cite: 5, 7]. [cite_start]Temel amacı, dinamik olarak oluşturulan bir harita üzerinde oyuncunun en kısa yolu bularak farklı türdeki hazineleri toplamasıdır[cite: 17, 18].

## 🚀 Proje Özellikleri

* [cite_start]**Dinamik Harita Oluşturma:** Kullanıcıdan alınan boyut değerine göre kareli bir oyun haritası oluşturulur[cite: 18, 19].
* [cite_start]**Tematik Bölgeler:** Harita "Yaz" ve "Kış" olmak üzere iki farklı temaya ayrılmıştır[cite: 20].
* [cite_start]**Çeşitli Hazineler:** Oyun içerisinde toplanabilir altın, gümüş, zümrüt ve bakır sandıklar bulunmaktadır[cite: 13, 17].
* [cite_start]**Engel Mekanikleri:** Sabit ve hareketli engeller oyuncunun yolunu kısıtlar[cite: 27, 30].
* [cite_start]**Yol Takibi:** Oyuncunun geçtiği yollar görsel olarak yeşil bir çizgi ile takip edilir[cite: 35, 36].

## 🛠 Kullanılan Teknolojiler

* [cite_start]**Dil:** C# [cite: 25, 41]
* [cite_start]**Platform:** .NET Windows Forms [cite: 11, 25, 26]
* [cite_start]**Geliştirme Ortamı:** Visual Studio IDE [cite: 11, 25, 42]

## 🧠 Uygulanan Algoritmalar ve Yaklaşımlar

* [cite_start]**A* (A-Star) Algoritması:** Oyuncunun sandıklara ulaşması için en kısa yolu hesaplamasında kullanılmıştır[cite: 40].
* **Nesne Yönelimli Programlama (NYP):**
    * [cite_start]**Soyutlama ve Kalıtım:** Engel ve lokasyon sınıfları `abstract` sınıflar üzerinden türetilmiştir[cite: 12, 27, 29].
    * [cite_start]**Çok Biçimlilik (Polymorphism):** Ortak metotlar `override` edilerek kullanılmıştır[cite: 29, 30].
* **Çakışma Kontrolü:** Engellerin rastgele yerleştirilmesi sırasında üst üste binmemeleri sağlanmıştır[cite: 32].

## 👥 Geliştiriciler

* [cite_start]**Sena KÖSEOĞLU** [cite: 3]
* [cite_start]**Reyhan KURTULMUŞ** [cite: 7]
