# 🏨 OtelRezervasyon – Otel Rezervasyon Hesaplama Uygulaması

C# ve Windows Forms ile geliştirilmiş basit bir otel rezervasyon uygulaması. Kullanıcı müşteri adı, oda tipi, gece sayısı ve gecelik fiyat girer; uygulama toplam tutarı hesaplar ve istenirse kahvaltı ücretini ekler.

Bu proje, Görsel Programlama dersi için hazırlanan bir alıştırma çalışmasıdır.

## Özellikler

- Müşteri adı girişi (TextBox)
- Oda tipi seçimi (ComboBox, dizi ve döngü ile doldurulur)
- Gece sayısı seçimi (NumericUpDown)
- Gecelik fiyat girişi (TextBox)
- Kahvaltı seçeneği (CheckBox, gece başına 250 TL)
- Hatalı girişlerde kullanıcıya uyarı mesajı (MessageBox)
- Sonucun ekranda gösterilmesi (Label)

## Kullanılan Kavramlar

- **Kapsülleme (Encapsulation):** Sınıf alanları `private`, dışarıya yalnızca property'ler açık
- **Property ile doğrulama:** Hatalı değerler `set` bloğunda `throw` ile engellenir
- **Hesaplanan property:** `Tutar` için ayrı alan yok, her okunduğunda hesaplanır
- **Hata yönetimi:** `try-catch` ile property hataları yakalanır
- **Güvenli dönüştürme:** Gecelik fiyat `decimal.TryParse` ile okunur

## Rezervasyon Sınıfı

| Üye | Tür | Açıklama |
|---|---|---|
| `MusteriAdi` | string | Boş bırakılamaz |
| `OdaTipi` | string | Boş bırakılamaz |
| `GeceSayisi` | int | 1 ile 30 arasında olmalı |
| `GecelikFiyat` | decimal | 0'dan büyük olmalı |
| `Tutar` | decimal | `GecelikFiyat * GeceSayisi` (salt okunur) |
| `KahvaltiliTutar(bool kahvalti)` | decimal | Kahvaltı varsa Tutar'a gece başına 250 TL eklenir, yoksa Tutar |

## Hata Mesajları

| Durum | Mesaj |
|---|---|
| Müşteri adı boş | Müşteri adı boş olamaz. |
| Oda tipi seçilmedi | Oda tipi seçilmelidir. |
| Gece sayısı aralık dışında | Gece sayısı 1 ile 30 arasında olmalı. |
| Gecelik fiyat 0 veya negatif | Gecelik fiyat 0'dan büyük olmalı. |
| Fiyat sayı değil | Geçerli bir fiyat girin. |

Hata durumunda sonuç etiketi değişmez, önceki yazı korunur.

## Form Kontrolleri

| Kontrol | Name |
|---|---|
| TextBox (müşteri adı) | `txtMusteri` |
| ComboBox (oda tipi) | `comboOda` |
| NumericUpDown (gece sayısı) | `nudGeceSayisi` |
| TextBox (gecelik fiyat) | `textGeceFiyat` |
| CheckBox (kahvaltı) | `chekKahvalti` |
| Button | `buttonRezervasyon` |
| Label | `lblSonuc` |

## Çalıştırma

1. Depoyu klonlayın veya ZIP olarak indirin.
2. `.sln` dosyasını **Visual Studio** ile açın.
3. **F5** tuşuna basarak çalıştırın.

**Gereksinimler:** Windows, Visual Studio (Windows Forms desteğiyle), .NET

## Örnek Kullanım

| Oda Tipi | Gece | Gecelik Fiyat | Kahvaltı | Ödenecek |
|---|---|---|---|---|
| Standart | 3 | 1000 | Hayır | 3.000,00 TL |
| Standart | 3 | 1000 | Evet | 3.750,00 TL |

## Proje Yapısı

```
OtelRezervasyon/
├── Rezervasyon.cs      → Rezervasyon sınıfı (alanlar, property'ler, hesaplamalar)
├── Form1.cs            → Form olayları (Form1_Load, btnRezervasyon_Click)
├── Form1.Designer.cs   → Form tasarımı (Visual Studio tarafından oluşturulur)
└── Program.cs          → Uygulamanın başlangıç noktası
```
