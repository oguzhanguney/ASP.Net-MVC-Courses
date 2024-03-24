
Bu derste Web Helper konusuna giriş yapacağız.

	-Web Helpers nedir?
		+asp.net mvc viewlarında kullanılan sistem.web.helpers namespace i altında bulunan yardımcı metotlardır.
		+gelişmiş html kontrollerinin elle oluşturulması yerine sunucu taraflı metotlarla hızlı bir şekilde oluşturulmasına imkan sağlar.

		ÖR:araç takip sistemi yaptıgımızı düşünelim.kullanıcı tarafından seçilen araçların kaç günde kaç km yaptıklarını gösteren istatistiksel bir grafik yani chart oluşturabiliriz.
		   aynı şekilde kullanıcı tarafından seçilen birden fazla aracın son x günde kaç km yaptıklarını gösteren bir grafik gösterebiliriz.
		
		+Yani web helpers ile birlikte grafikler oluşturabiliyoruz.

		ÖR:Online satış sitesinde kullanıcı tarafından sisteme yüklenen resimleri yazı yada resimle watermark ekleyebiliriz.bu resimleri kırpabilir,döndürebiliriz.

		+Yani web helpers ile birlikte resimlerde işlemler(web image ile) yapabiliyoruz.

		ÖR:Stok takip sistemi gibi yazılımlarda ürünleri bir grid yardımı ile kullanıcılara gösterebiliriz.bu grid üzerinde arama ,ürünle ilgili işlem,yada bu gridin excel ve pdf çıktısını alabiliriz.

		+*Sonuç olarak En çok kullanılan Web helpers=  1-grafiksel rapor oluşturan chartlar,
													   2-resim işleme
													   3-grid üzerinde veri görüntüleme -web grid işlem yapma 
													   
													   bunların dışında 
													   4-crypto:şifreleme fakat			****	C# ta şifreleme için System.Security.Cryptography kullanılır.
													   5-webmail :mail gönderme işlemi  ****	C# ta mail için System.Net kullanılır.

		+Asp.net mvc projelerinde web helper ları kullanmak için view yada controllerda System.Web.Helpers namespace sini eklememiz gerekir.	


	1)Charts:(@using System.Web.Helpers)
		AddSeries metodu içerisinde charttype propertisi ile chartların tipini değiştirebiliriz.(chartType:"Point") (Buble,Line,Spline,Column,Bar,Area,SplineArea,Pie,Doughnut: default -Column )

	2)İmages:
		İlk önce resmimizi yüklememiz gerekir.sonra bu resmin yolunu bir prop yardımıyla gerçekleştirmemiz gerekir.

	3)Web Grid:
		asp.net mvc projelerinde server side yani sayfalama yapabilen  veri türlerini strongly type olarak kullanabilen ve istendiğinde Ajax desteği ile eklenebilecek bir grid yapısı bulunmaktadır.
		web grid yardımcı sınıfı ile bu grid yapısını oluşturabiliriz. bir urun controller oluşturup grid yapısını kullanalım. 

		web grid düzenleme işlemleri yapalım. column isimlerini değiştirelim. ve hangi sütuna göre sıralamak istedigimizi belirtelim. ve rowsperpage ile bir sayfa içerisinde kaç tane gösterecegimizi belirtelim.
		ilk sayfaya ve son sayfaya git eklemek içinde mode parametresini kullanalım.

		Web gridde satırı tıklanabilir yapmak için layout sayfamızı açıyoruz ve style tanımlıyoruz.Ve bir script tagi açıp jquery toggle ile bunu tetikleyelim.
		bunu layoutta yapmamızın nedeni eğer ürünlistesinde yapsaydık renderbody scriptlerin üzerinde oldugu için jquery sınıfı tanınmamış olacaktı ve çalışmayacaktı.

		şimdi grid nesneleri içerisinde arama işlemi yapacagız.ürün adlarına göre arama yapacagız.bu işlemi de veri diye bir sınıf oluşturup yapacagız.


		şimdi biz bu web grid verilerini excell e aktaralım.
		-Öncelikle uruncontroller içerisinde ürünleriexcele aktar diye bir actionresult tanımlayalım.

		
