#  <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> EĞİTİM KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu C# Eğitim Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde 501 modül olan Dapper konuları anlatılmaktadır.

## 🖥️ C# Eğitim Kampı Ders 22 - C# ile Dapper Kullanımı
### 📆 Tarih: 16 Aralık 2024

Bir önceki dersimizde eksik olan kısımlarımızı tamamlıyoruz.

![image](https://github.com/user-attachments/assets/a8aa727b-e354-4de0-8aed-cf8c12915ed9)

![image](https://github.com/user-attachments/assets/354e9b90-a4eb-4d22-8d02-3a7b363225fa)

FrmProduct formunda yer alan ekleme işleminin kodları ve çıktısı bu şekildedir.

![image](https://github.com/user-attachments/assets/cc376271-fd66-440d-a6c0-908ad63014cb)

![image](https://github.com/user-attachments/assets/c4798961-3cf4-4864-921e-09b46dbbfc8d)

Silme işleminin kodları ve çıktısı bu şekildedir.

![image](https://github.com/user-attachments/assets/7cc78e76-1c59-4546-be13-fcd11b2a60c3)

ID'ye göre getirme işlemi bu şekildedir.

![image](https://github.com/user-attachments/assets/3f00f6fb-b1c4-4eba-a4d3-59803a69a823)

![image](https://github.com/user-attachments/assets/2d56a5de-eaef-46a3-9b04-cf69d4688b81)

Güncelleme işleminin kodları ve çıktısı bu şekildedir.

CRUD işlemleri tamamladıktan sonra formumuza çift tıklayıp ComboBox'ta yer alan kategorileri getirme işlemini yapıyoruz.

![image](https://github.com/user-attachments/assets/2d339c1a-c5e8-4c9c-96be-d28c4ffdb287)

![image](https://github.com/user-attachments/assets/5fc3514c-d0b9-474d-be35-76983ba583bf)

ComboBox'a kategorileri getirme işlemi bu şekildedir, ancak ekleme işlemi için küçük bir değişiklik yapıyoruz.

![image](https://github.com/user-attachments/assets/61beeece-7053-4208-bf05-84c1457d3745)

Ekleme işleminde cmbCategory.Text yerine cmbCategory.SelectedValue.ToString() komutunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/de04f944-4ccd-4e3d-b66a-70aecd707a07)

Kategorilerimiz comboBox'a aktarılmıştır.

## Dapper nedir?

Dapper, bir .NET uygulamasında kullanılan, hafif ve hızlı bir micro ORM (Object-Relational Mapper) kütüphanesidir. Dapper, SQL sorgularını çalıştırmayı ve veri tabanı ile uygulama arasında veri alışverişini kolaylaştırmayı amaçlar. Özellikle performans ve esneklik gereksinimi olan durumlar için tercih edilir.

### Özellikleri:

Performans: Dapper, doğrudan ADO.NET kullanarak çalışır, bu yüzden oldukça hızlıdır.

Hafiflik: ORM araçlarının getirdiği karmaşıklıklardan kaçınır. Sadece ihtiyacınız olan veriyi hızlıca almanıza odaklanır.

SQL ile Çalışma: SQL sorgularınızı doğrudan yazabilirsiniz, yani Entity Framework gibi soyutlama katmanlarına gerek yoktur.

Dinamik Nesne Desteği: Dönen sonuçları dinamik nesnelere ya da kendi tanımladığınız sınıflara kolayca eşleyebilir.

Destek: .NET ve .NET Core projeleriyle uyumludur.

### Avantajları:

Büyük ve karmaşık ORM araçlarına göre daha hafif ve hızlıdır.

Mevcut SQL sorgularıyla kolayca entegre edilebilir.

Veritabanı yönetiminde daha fazla kontrol sağlar.

Dapper, özellikle performansın kritik olduğu projelerde, hızlı ve kolay veri erişimi sağlamak için sıkça tercih edilir.

İlk önce SQL üzerinden yeni bir veri tabanı oluşturuyoruz. İsmini Bootcamp501Db olarak belirledim. Daha sonra tablolarımızı oluşturuyoruz.

![image](https://github.com/user-attachments/assets/cd1a897a-4400-443e-8e7d-bf1671ac8a72)

TblProduct tablosunu oluşturduk.

![image](https://github.com/user-attachments/assets/493d7a8f-4479-4590-b840-d666b383ad07)

TblProduct'a ait veri girişlerimizi yaptık.
