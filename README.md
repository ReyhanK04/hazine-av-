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

<img width="1190" height="867" alt="Ekran görüntüsü 2024-03-18 040317" src="https://github.com/user-attachments/assets/6124d2f6-ef0f-49c4-932a-e9379f280207" />
<img width="1182" height="886" alt="Ekran görüntüsü 2024-03-18 040328" src="https://github.com/user-attachments/assets/5af76e4a-b883-44e1-a3e8-c005ed552723" />
<img width="1170" height="893" alt="Ekran görüntüsü 2024-03-18 040334" src="https://github.com/user-attachments/assets/1337b071-db69-450c-ba7c-34443dc0f00e" />
<img width="1173" height="868" alt="Ekran görüntüsü 2024-03-18 040341" src="https://github.com/user-attachments/assets/08a63c52-8957-4cab-a6c8-fad1d414560c" />
<img width="1215" height="897" alt="Ekran görüntüsü 2024-03-18 040348" src="https://github.com/user-attachments/assets/70f98e97-158b-4469-9a3f-1f84f0b4960d" />
<img width="1286" height="914" alt="Ekran görüntüsü 2024-03-18 040425" src="https://github.com/user-attachments/assets/64ccfc3b-4749-437e-b647-8dc0406c499b" />






