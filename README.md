# Hazine Avı (Treasure Hunt) - 2D Grid Based Game 

Bu proje, **Kocaeli Üniversitesi Bilgisayar Mühendisliği Programlama Laboratuvarı II** dersi kapsamında geliştirilmiştir. Temel amacı, dinamik olarak oluşturulan bir harita üzerinde oyuncunun en kısa yolu bularak farklı türdeki hazineleri toplamasıdır.

## 🚀 Proje Özellikleri

* **Dinamik Harita Oluşturma:** Kullanıcıdan alınan boyut değerine göre kareli bir oyun haritası oluşturulur.
* **Tematik Bölgeler:** Harita "Yaz" ve "Kış" olmak üzere iki farklı temaya ayrılmıştır.
* **Çeşitli Hazineler:** Oyun içerisinde toplanabilir altın, gümüş, zümrüt ve bakır sandıklar bulunmaktadır.
* **Engel Mekanikleri:** Sabit ve hareketli engeller (duvarlar, ağaçlar, dağlar vb.) oyuncunun yolunu kısıtlar.
* **Yol Takibi:** Oyuncunun geçtiği yollar görsel olarak yeşil bir çizgi ile takip edilir.

## 🛠 Kullanılan Teknolojiler

* **Dil:** C# 
* **Platform:** .NET Windows Forms 
* **Geliştirme Ortamı:** Visual Studio IDE

## 🧠 Uygulanan Algoritmalar ve Yaklaşımlar

* **A* (A-Star) Algoritması:** Oyuncunun sandıklara ulaşması için en kısa yolu hesaplamasında bu algoritma mantığı kullanılmıştır.
* **Nesne Yönelimli Programlama (NYP):**
    * **Soyutlama ve Kalıtım:** Engel ve lokasyon sınıfları `abstract` sınıflar üzerinden türetilmiştir.
    * **Çok Biçimlilik (Polymorphism):** Ortak metotlar `override` edilerek kullanılmıştır.
* **Çakışma Kontrolü:** Engellerin rastgele yerleştirilmesi sırasında üst üste binmemeleri için özel kontroller yapılmıştır.

## 👥 Geliştiriciler

* **Sena KÖSEOĞLU** 
* **Reyhan KURTULMUŞ** 
