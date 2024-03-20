
Bu derste Web Helper konusuna giriş yapacağız.

	-Web Helpers nedir?
		+asp.net mvc viewlarında kullanılan sistem.web.helpers namespace i altında bulunan yardımcı metotlardır.
		+gelişmiş html kontrollerinin elle oluşturulması yerine sunucu taraflı metotlarla hızlı bir şekilde oluşturulmasına imkan sağlar.

		ÖR:araç takip sistemi yaptıgımızı düşünelim.kullanıcı tarafından seçilen araçların kaç günde kaç km yaptıklarını gösteren istatistiksel bir grafik yani chart oluşturabiliriz.
		   aynı şekilde kullanıcı tarafından seçilen birden fazla aracın son x günde kaç km yaptıklarını gösteren bir grafik gösterebiliriz.
		
		+Yani web helpers ile birlikte grafikler oluşturabiliyoruz.

		ÖR:Online satış sitesinde kullanıcı tarafından sisteme yüklenen resimleri yazı yada resimle watermark ekleyebiliriz.bu resimleri kırpabilir,döndürebiliriz.

		+Yani web helpers ile birlikte resimlerde işlemler yapabiliyoruz.

		ÖR:Stok takip sistemi gibi yazılımlarda ürünleri bir grid yardımı ile kullanıcılara gösterebiliriz.bu grid üzerinde arama ,ürünle ilgili işlem,yada bu gridin excel ve pdf çıktısını alabiliriz.

		+*Sonuç olarak En çok kullanılan Web helpers=  1-grafiksel rapor oluşturan chartlar,
													   2-resim işleme
													   3-grid üzerinde veri görüntüleme -web grid işlem yapma 
													   
													   bunların dışında 
													   4-crypto:şifreleme fakat			****	C# ta şifreleme için System.Security.Cryptography kullanılır.
													   5-webmail :mail gönderme işlemi  ****	C# ta mail için System.Net kullanılır.

		+Asp.net mvc projelerinde web helper ları kullanmak için view yada controllerda System.Web.Helpers namespace sini eklememiz gerekir.	


	1)Chart oluşturma:
		AddSeries metodu içerisinde charttype propertisi ile chartların tipini değiştirebiliriz.(chartType:"Point") (Buble,Line,Spline,Column,Bar,Area,SplineArea,Pie,Doughnut: default -Column )
