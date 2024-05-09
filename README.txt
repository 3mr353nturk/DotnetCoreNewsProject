Proje A��klamas�:

Bu proje, ASP.NET Core MVC kullan�larak geli�tirilmi� bir haber portal� uygulamas�d�r. 
Uygulama, katmanl� mimari yap�s�n� takip eder ve haberleri almak i�in HttpClient kullan�larak ilgili json dosyalar�ndan veriler �ekilir.

Katmanlar:

1. DataAccess: Veri eri�im katman�d�r.
   - NewsRepository: HttpClient ile ilgili json dosyalar�ndan haber verilerini almak i�in kullan�l�r.
  
2. Business: �� katman�d�r.
   - NewsService: Haber verileriyle ilgili i�lemler ger�ekle�tirir. Haberleri filtreleme ve listeleme gibi i�lemleri yapar.

3. Core: Temel s�n�flar� i�eren katmand�r.
   - NewsItem: Haberi temsil eden s�n�ft�r. Her bir haberin �zelliklerini i�erir.
   - NewsDetail: Haber detay�n� temsil eden s�n�ft�r. Haberin ba�l���n� ve i�eri�ini i�erir.
   - Category: Haberin kategorisini temsil eden s�n�ft�r.

Controller:

1. NewsController: HTTP isteklerini al�r, ilgili metodlar� �a��r�r ve d�nen sonu�lar� View'lere ileterek kullan�c� aray�z�n� olu�turur.
   - Index: Ana sayfa i�in haber listesini g�r�nt�ler. Filtreleme ve sayfalama i�lemlerini yapar.
   - Details: Haber detay sayfas�n� g�r�nt�ler. Haber detaylar�n� al�r ve ilgili sayfay� a�ar.