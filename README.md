#  <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> EĞİTİM KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu C# Eğitim Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde 501 modül olan Dapper konusundan itibaren anlatılmaktadır.

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

Yeni bir .NET Framework projesi oluşturuyoruz. İsmini CSharpBootcamp501 olarak belirledim.

![image](https://github.com/user-attachments/assets/28de45b9-600c-4c1d-9940-5a58e42e219a)

Formumuzun tasarımı bu şekildedir.

![image](https://github.com/user-attachments/assets/3e32c370-9ee7-4658-bffa-0ed7a944d0d5)

Formumuza Dtos ve Repositories adında 2 tane klasör ekliyoruz.

Dtos klasörüne sağ tıklayıp yeni bir class oluşturuyoruz ve ismini ResultProductDto olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/e106834b-e650-49d2-9506-a0fbd1df8b11)

Bu class'ın içinde SQL'den gelen tablomuzun propertylerini tutuyor olacağız. SQL'de yer alan propertylerin aynısını buraya yazıyoruz.

Tekrardan bir class açıp bu kez ismini CreateProductDto olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/d08ec43d-b37c-4011-b0ae-58e40af281c3)

ResultProductDto'da yer alan kodların aynısını buraya da aktarıyoruz. Böylece SQL'de yer alan sütunlarıyla burada yer alan propertylerle eşleştiriyoruz. Burada ID eklemeye gerek yoktur.

![image](https://github.com/user-attachments/assets/bec48004-cc37-4e3b-b711-d48c852ded4b)

Bu kez UpdateProductDto class'ı oluşturuyoruz ve tekrardan kodları yapıştırıyoruz.

## DTO Nedir?

DTO (Data Transfer Object), yazılım geliştirme süreçlerinde, verileri bir katmandan diğerine taşımak için kullanılan bir nesnedir. Genellikle veritabanı ile uygulama veya farklı servisler arasındaki veri alışverişini kolaylaştırmak için kullanılır. DTO'nun temel amacı, sadece veri taşımak olduğundan, genellikle iş mantığı veya davranış içermez.

### Özellikleri:
Sadece veri taşır: DTO'lar genellikle getter ve setter metodları olan basit sınıflardır.

Serileştirilebilir: Veri aktarımı sırasında JSON, XML gibi formatlara dönüştürülebilir.

Kolay okuma ve düzenleme sağlar: Aktarılan verinin yapısını daha anlaşılır hale getirir.

### Kullanım Alanları:
API Geliştirme: İstemci ve sunucu arasındaki veri alışverişinde.

Mikroservis Mimarisi: Farklı servisler arasında veri taşırken.

Katmanlı Mimariler: Veritabanı katmanından iş mantığı veya sunum katmanına veri taşırken.

DTO işlemleri tamamlandıktan sonra bu kez Repositories klasörü üzerinde işlemlerimizi yapacağız. Bunun için Repositories klasörüne sağ tıklayıp Add kısmından New Item diyoruz ve yeni bir Interface ekliyoruz. İsmini IProductRepository olarak belirliyoruz.

Burada asenkron metotlar kullanacağız.

![image](https://github.com/user-attachments/assets/4ec5c7b4-09c8-494a-b90f-0d9da121615d)

Kodlarımız bu şekildedir.

## Async Nedir?

C#'ta async anahtar kelimesi, bir metodun asenkron olarak çalışabileceğini belirtir. Asenkron programlama, bir metodun uzun süren işlemleri (örneğin dosya okuma/yazma, veri tabanı sorguları, ağ istekleri) beklemeden çalıştırılmasına olanak tanır. Bu, uygulamanın yanıt vermeye devam etmesini ve kullanıcı arayüzünün donmamasını sağlar.

### async Anahtar Kelimesinin Kullanımı

Bir metodu asenkron hale getirmek için async anahtar kelimesi kullanılır. Bu tür metotlar genellikle bir Task veya Task<T> döndürür.

Repository klasöründen bu kez bir tane class oluşturuyoruz ve ismini ProductRepository olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/464cd622-cedb-4001-9f9a-ecbcf096169d)

Buradan IProductRepository'i miras olarak alıyoruz ve hatayı önlemek için implement interface diyoruz.

Repository işlemlerimizi tamamladıktan sonra katmanımıza sağ tıklayıp Manage NuGet Packages diyoruz. 

![image](https://github.com/user-attachments/assets/8ffb7295-ff21-457d-8e0a-27ce0950fb84)

Buradan Dapper isminde bir paket yüklüyoruz.

✅ Bu eğitimde Dapper, DTO özelliklerini, Repository işlemlerinin nasıl yapıldığını ve asenkron metotlarının kullanımını öğrendim ve uyguladım.
