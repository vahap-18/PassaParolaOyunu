# PassaParola Oyunu 🎮

Bu proje, klasik bir bilgi yarışması olan "PassaParola" oyununu temel alır. Oyunculara harf sırasına göre sorular sorulur ve doğru ya da yanlış cevaplara göre istatistik tutulur. 

---

## Özellikler 📋

- **Soru Mantığı:**  
  Oyunda toplam 24 soru bulunmaktadır. Her soru, belirli bir harfe atanmış ve bu harf ile başlayan bir cevabı içerir. Oyuncular doğru cevabı verirse butonlar **yeşil**, yanlış cevap verirlerse **kırmızı** olur.

- **Doğru/Yanlış İstatistikleri:**  
  Oyuncunun doğru ve yanlış cevapları sayılarak sonuç ekranında görüntülenir.

- **Sadece Enter Tuşu ile Cevaplama:**  
  Oyuncular, cevaplarını metin kutusuna yazdıktan sonra yalnızca **Enter** tuşuna basarak gönderebilir.

---

## Oyun Nasıl Oynanır? 🎲

1. Oyunu başlatın. İlk soru ekranı ile karşılaşacaksınız. 
2. Soru kutucuğunda yer alan sorunun cevabını metin kutusuna yazın. Cevabınızı yazdıktan sonra **Enter** tuşuna basarak yanıtınızı gönderin.
3. Doğru cevap verdiğinizde harfe ait buton yeşil, yanlış cevap verdiğinizde kırmızı renge döner.
4. Tüm sorular bittiğinde oyunun sonuç ekranı ile karşılaşırsınız.
5. İsterseniz oyunu tekrar oynayabilirsiniz.

---

## Kod Mantığı 🛠️

- **Soru Akışı:**  
  Oyundaki sorular, `QuestionNo` değişkenine göre sırayla gösterilir. Her soruya özel bir buton ve cevap atanmıştır. 

- **Cevap Kontrolü:**  
  Cevap, metin kutusundan alınır ve `Trim()` ile baştaki/sondaki boşluklar temizlenerek doğru cevapla karşılaştırılır.  
  ```csharp
  if (tbAnswer.Text.Trim().ToLower() == correctAnswer)
  {
      currentButton.BackColor = Color.GreenYellow;
      TrueQuestion++;
  }
  else
  {
      currentButton.BackColor = Color.Red;
      FalseQuestion++;
  }
  ```

- **Oyunun Bitimi:**  
  Sorular bittiğinde, oyuncuya bir mesaj kutusu ile oyun tamamlandığı bildirilir. Oyun sıfırlama seçeneği sunulur.

---

## Ekran Görselleri 🖼️

### 1. Oyun Başlangıç Ekranı  
Oyuna ilk girişte karşınıza çıkan ekran. Harfler ve istatistikler sıfırlanmış şekilde başlar.  

![başlangıç](https://github.com/user-attachments/assets/e5e03aa1-3ee1-414c-a53b-15833c426cc4)


### 2. Oyun Ekranı  
Oyun sırasında bir soruya cevap verirken ekran görüntüsü.  

![Son soru](https://github.com/user-attachments/assets/3f4eedbd-e6c8-4929-bdf5-2f3d96746451)


### 3. Oyun Bitiş Ekranı  
Tüm sorular cevaplandıktan sonra bitiş ekranı. Doğru ve yanlış sayılarınız gösterilir.  

![Bitmis](https://github.com/user-attachments/assets/d60aa0b0-3068-487f-bbfb-e55d27eb0e58)


---

## Kullanılan Teknolojiler ve Araçlar ⚙️

- **Programlama Dili:** C#
- **IDE:** Visual Studio
- **Framework:** Windows Forms

---

## İleride Eklenebilecek Özellikler ✨

1. **Yeni Sorular ve Dinamik Veri:** Soruların harici bir dosyadan veya bir veritabanından çekilmesi.  
2. **Zamanlama Mekanizması:** Oyuncuların belirli bir süre içinde cevap vermesi gerektiği bir süre sistemi.  
3. **Ses Efektleri:** Doğru ve yanlış cevaplar için ses efektleri eklenmesi.

---

## Nasıl Çalıştırılır? 🚀

1. Projeyi klonlayın:  
   ```bash
   git clone https://github.com/username/PassaParolaOyunu.git
   ```
2. Visual Studio ile projeyi açın.
3. `Form1.cs` dosyasını kontrol edin ve eksik kütüphaneler varsa yükleyin.
4. Projeyi derleyip çalıştırın.

---

