Proje Açýklamasý:

Bu proje, ASP.NET Core MVC kullanýlarak geliþtirilmiþ bir haber portalý uygulamasýdýr. 
Uygulama, katmanlý mimari yapýsýný takip eder ve haberleri almak için HttpClient kullanýlarak ilgili json dosyalarýndan veriler çekilir.

Katmanlar:

1. DataAccess: Veri eriþim katmanýdýr.
   - NewsRepository: HttpClient ile ilgili json dosyalarýndan haber verilerini almak için kullanýlýr.
  
2. Business: Ýþ katmanýdýr.
   - NewsService: Haber verileriyle ilgili iþlemler gerçekleþtirir. Haberleri filtreleme ve listeleme gibi iþlemleri yapar.

3. Core: Temel sýnýflarý içeren katmandýr.
   - NewsItem: Haberi temsil eden sýnýftýr. Her bir haberin özelliklerini içerir.
   - NewsDetail: Haber detayýný temsil eden sýnýftýr. Haberin baþlýðýný ve içeriðini içerir.
   - Category: Haberin kategorisini temsil eden sýnýftýr.

Controller:

1. NewsController: HTTP isteklerini alýr, ilgili metodlarý çaðýrýr ve dönen sonuçlarý View'lere ileterek kullanýcý arayüzünü oluþturur.
   - Index: Ana sayfa için haber listesini görüntüler. Filtreleme ve sayfalama iþlemlerini yapar.
   - Details: Haber detay sayfasýný görüntüler. Haber detaylarýný alýr ve ilgili sayfayý açar.